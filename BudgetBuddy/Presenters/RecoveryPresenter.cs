using BudgetBuddy.Models;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Presenters
{
    public class RecoveryPresenter
    {
        // fields Dependency Injection
        private readonly IAccountRepository _accountRepository;
        private readonly IRecoveryView _view;

        // constructor
        public RecoveryPresenter(IAccountRepository accountRepository, IRecoveryView view)
        {
            _accountRepository = accountRepository;
            _view = view;
            // subscribe the view's event to the presenter's event
            _view.RecoverAccountEvent += RecoverAccount;


        }

        private void RecoverAccount(object sender, EventArgs e)
        {
            // mapping account class
            var recoverAccount = new Models.Account
            {
                Email = _view.Email,
            };

            try
            {
                // querying from AccontRepository
                // returns an integer 
                if (_accountRepository.RecoverAccount(recoverAccount) == 0)
                {

                    _view.isSuccessful = false;
                }
                else
                {
                    _view.isSuccessful = true;

                }


            }
            catch (Exception)
            {
                return;
            }
        }

        // constructor overloading
        public RecoveryPresenter()
        {

        }

    }
}
