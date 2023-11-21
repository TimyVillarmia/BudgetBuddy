using BudgetBuddy.Models;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Presenters
{
    public class SignInPresenter
    {
        // fields Dependency Injection
        private IAccountRepository _accountRepository;
        private ISignInView _view;

        // constructor
        public SignInPresenter(IAccountRepository accountRepository, ISignInView view)
        {
            _accountRepository = accountRepository;
            _view = view;
            _view.LoginAccountEvent += LoginAccount;

            
        }

        // constructor overloading
        public SignInPresenter()
        {

        }


        // methods
        private void LoginAccount(object sender, EventArgs e)
        {
            try
            {
                // mapping account class
                var loginAccount = new Models.Account();
                loginAccount.Email = _view.Email;
                loginAccount.Password = _view.Password;


                // querying from AccontRepository
                // returns an integer 
                if (_accountRepository.LoginAccount(loginAccount) == 1)
                {
                    
                    _view.isSuccessful = true;
                   
                }
                else
                {
                    _view.isSuccessful = false;

                }


            }
            catch(Exception ex)
            {
                return;
            }


        }

    }
}
