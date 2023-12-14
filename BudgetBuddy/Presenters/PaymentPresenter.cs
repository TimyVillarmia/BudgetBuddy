using BudgetBuddy._Repositories;
using BudgetBuddy.Models;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Presenters
{
    public class PaymentPresenter
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IPaymentView _view;

        public PaymentPresenter(IAccountRepository accountRepository, IPaymentView view)
        {

            _accountRepository = accountRepository;
            _view = view;


            _view.PayEvent += PayMethod;
            _view.LoadEvent += LoadMethod;
        }

        private void LoadMethod(object sender, EventArgs e)
        {
            var external_ID = _accountRepository.GetBankAccountExternal_ID(Session.CurrentUser);


            if (external_ID != null)
            {
                var checking = external_ID.Where(check => check.account_type == "checking").FirstOrDefault();

                _view.hasAccount = (checking == null) ? false : true;

                //var chcking_account = await MetrobankRepository.GetAccountFromJSONServer(checking.external_id);

                //_view.Email = chcking_account.email;
                //_view.Sender_number = chcking_account.account_number;
                //_view.Sender_name = chcking_account.owner_name;

                var task = Task.Run(async () =>
                {
                    var chcking_account = await MetrobankRepository.GetAccountFromJSONServer(checking.external_id);

                    _view.Email = chcking_account.email;
                    _view.Sender_number = chcking_account.account_number;
                    _view.Sender_name = chcking_account.owner_name;
                });

                task.Wait();
            }
            else
            {
                _view.hasAccount = false;

            }



        }

        private void PayMethod(object sender, EventArgs e)
        {


            var createNewTransaction = new transaction
            {

                receiver_name = _view.PayToAccountName,
                sender_name = _view.Sender_name,
                transaction_type = "Payments",
                transaction_name = _view.TransactionName,
                amount = _view.MoneyTransferAmount,
                transaction_date = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"))
            };

            _accountRepository.CreateTransactions(createNewTransaction);
        }
    }
    
}
