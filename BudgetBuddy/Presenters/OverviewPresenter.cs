using BudgetBuddy.Models;
using BudgetBuddy.Views;
using BudgetBuddy.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BudgetBuddy.Presenters
{
    public class OverviewPresenter
    {
        // fields Dependency Injection
        private readonly IAccountRepository _accountRepository;
        private readonly IOverviewView _view;
        private readonly IAddCardView _view1;


        // constructor
        public OverviewPresenter(IAccountRepository accountRepository, IOverviewView view, IAddCardView view1)
        {
            _accountRepository = accountRepository;
            _view = view;
            _view1 = view1;

            // subscribe the view's event to the presenter's event
            _view.LoadOverviewData += GetCard;
            _view1.AddNewCardEvent += AddCardMethod;


        }

        private void GetCard(object sender, EventArgs e)
        {
            var email = new account
            {
                email = Session.CurrentUser
            };

            try
            {
                var acc = _accountRepository.GetAccount(email);
                if (acc != null) 
                { 
                    _view.CardNumber = acc.account_number;
                    _view.Name = acc.owner_name;
                    _view.ExpiryDate = acc.expiry_date.ToString("MM/yy");

                    _view.HasAccount = true;
                    
                }
                else
                {
                    _view.HasAccount = false;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void AddCardMethod(object sender, EventArgs e)
        {
            var newCard = new account
            {
                account_number = _view1.Card.CardNumber,
                owner_name = _view1.Card.Name,
                expiry_date = _view1.Card.ExpiryDate,
                email = _view1.Card.Email
            };


            try
            {


                if (_accountRepository.AddCard(newCard, _view1.Card.PIN))
                {
                    _view1.isSuccessful = true;
                }
                else
                {
                    _view1.isSuccessful = false;
                    

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
