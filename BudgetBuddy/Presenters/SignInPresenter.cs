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
        private IAccountRepository _accountRepository;
        private ISignInView _view;
        public SignInPresenter(IAccountRepository accountRepository, ISignInView view)
        {
            _accountRepository = accountRepository;
            _view = view;
            _view.LoginAccountEvent += LoginAccount;

            
        }

        public SignInPresenter()
        {

        }



        private void LoginAccount(object sender, EventArgs e)
        {
            try
            {
                var loginAccount = new Models.Account();
                loginAccount.Email = _view.Email;
                loginAccount.Password = _view.Password;
                _view.test = _view.Email;



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
