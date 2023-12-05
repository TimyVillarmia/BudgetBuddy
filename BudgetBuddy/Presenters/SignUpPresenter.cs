using System;
using System.Windows.Forms;
using BudgetBuddy.Models;
using BudgetBuddy.Views;

namespace BudgetBuddy.Presenters
{
    public class SignUpPresenter
    {
        private IAccountRepository _accountRepository;
        private ISignUpView _view;

        public SignUpPresenter(IAccountRepository accountRepository, ISignUpView view)
        {
            this._accountRepository = accountRepository;
            this._view = view;

            this._view.CreateAccountEvent += CreateAccount;

        }




        private void CreateAccount(object sender, EventArgs e)
        {
            var newUser = new user
            {
                email = _view.Email.Trim().ToLower(),
                password_hash = _view.Password.Trim()

            };

            var newUser_detail = new user_detail
            {
                first_name = _view.FirstName.Trim(),
                last_name = _view.LastName.Trim(),
                
            };



            try
            {

                if (_accountRepository.CreateAccount(newUser, newUser_detail))
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
                MessageBox.Show($"{ex}");
            }

            


        }
    }
}
