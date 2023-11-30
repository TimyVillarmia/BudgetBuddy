using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BudgetBuddy.Models;
using BudgetBuddy.Views;
using BudgetBuddy._Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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


            var newAccount = new user
            {
                email = _view.Email,
                first_name = _view.FirstName,
                last_name = _view.LastName,
                password_hash = _view.Password
                
            };

            try
            {

                if (_accountRepository.CreateAccount(newAccount))
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
