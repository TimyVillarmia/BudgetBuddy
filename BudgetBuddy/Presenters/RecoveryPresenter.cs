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
        private readonly IRecovery1View _view1;
        private readonly IRecovery2View _view2;

        // constructor
        public RecoveryPresenter(IAccountRepository accountRepository, IRecovery1View view1, IRecovery2View view2)
        {
            _accountRepository = accountRepository;
            _view1 = view1;
            _view2 = view2;
            // subscribe the view's event to the presenter's event
            _view1.RecoverAccountEvent += CheckAccount;
            _view2.UpdatePasswordEvent += UpdatePassword;


        }

        private void UpdatePassword(object sender, EventArgs e)
        {
            var updateAccount = new Models.Account
            {
                Email = _view1.Email,
                Password = _view2.Password
            };

            try
            {
                // querying from AccontRepository
                // returns an integer 
                if (_accountRepository.RecoverAccount(updateAccount) == true)
                {

                    _view2.isSuccessful = true;
                }
                else
                {
                    _view2.isSuccessful = false;

                }
            }
            catch(Exception)
            {
                return;
            }
        }

        private void CheckAccount(object sender, EventArgs e)
        {
            // mapping account class
            var recoverAccount = new Models.Account
            {
                Email = _view1.Email,
            };

            try
            {
                // querying from AccontRepository
                // check if account exist before proceeding to account recovery
                if (_accountRepository.doesAccountExist(recoverAccount) == false)
                {

                    _view1.isSuccessful = false;
                }
                else
                {
                    _view1.isSuccessful = true;

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
