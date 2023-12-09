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
        }

        private void PayMethod(object sender, EventArgs e)
        {
            var createNewTransaction = new transaction
            {
                receiver_account_number = _view.PayToAccountNumber,
                transaction_type = "Payments",
                transaction_name = _view.PayToAccountName,
                amount = _view.MoneyTransferAmount,
                transaction_date = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"))
            };

            _accountRepository.CreateTransactions(createNewTransaction);
        }
    }
    
}
