using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var newAccount = new Models.Account
            {
                FirstName = _view.FirstName,
                LastName = _view.LastName,
                Email = _view.Email,
                Password = _view.Password,
            };

            try
            {
                _accountRepository.CreateAccount(newAccount);
            }
            catch   
            {
                MessageBox.Show("Error");
            }

            


        }
    }
}
