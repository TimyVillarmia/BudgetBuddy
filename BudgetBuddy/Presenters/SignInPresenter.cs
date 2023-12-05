using BudgetBuddy.Models;
using BudgetBuddy.Repositories;
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
        private readonly IAccountRepository _accountRepository;
        private readonly ISignInView _view;

        // constructor
        public SignInPresenter(IAccountRepository accountRepository, ISignInView view)
        {
            _accountRepository = accountRepository;
            _view = view;
            // subscribe the view's event to the presenter's event
            _view.LoginAccountEvent += LoginAccount;

            
        }

        // constructor overloading
        public SignInPresenter()
        {

        }


        // methods
        private void LoginAccount(object sender, EventArgs e)
        {
            
            // mapping account class
            var loginAccount = new user
            {
                email = _view.Email.Trim().ToLower(),
                password_hash = _view.Password.Trim()
            };

            try
            {

                // querying from AccontRepository
                if (_accountRepository.LoginAccount(loginAccount))
                {
                    _view.isSuccessful = true;

                }
                else
                {
                    _view.isSuccessful = false;

                }


            }
            catch(Exception)
            {
                return;
            }


        }

    }
}
