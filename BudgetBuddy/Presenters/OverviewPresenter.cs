using BudgetBuddy.Models;
using BudgetBuddy.Views;
using BudgetBuddy.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
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
        private IEnumerable<Users> accountList;
        private BindingSource bankBindingSource;


        // constructor
        public OverviewPresenter(IAccountRepository accountRepository, IOverviewView view, IAddCardView view1)
        {
            this.bankBindingSource = new BindingSource();


            _accountRepository = accountRepository;
            _view = view;
            _view1 = view1;



            // subscribe the view's event to the presenter's event
            _view.LoadOverviewData += GetCard;
            _view.SearchAccountEvent += SearchAccount;
            _view1.AddNewCardEvent += AddCardMethod;


            this._view.SetBankListBindingSource(bankBindingSource);
            LoadAllBankList();



        }

        private void LoadAllBankList()
        {
            accountList = _accountRepository.GetBankAccountList();
            bankBindingSource.DataSource = accountList;//Set data source.
        }

        private void SearchAccount(object sender, EventArgs e)
        {

            
            try
            {

                bool emptyValue = string.IsNullOrWhiteSpace(_view.SearchName);

                if (emptyValue)
                {
                    accountList = _accountRepository.GetBankAccountList();


                }
                else
                {
                    accountList = _accountRepository.GetBankAccountList().Where(search => search.DisplayName.ToLower().StartsWith(_view.SearchName)); 

                }

                bankBindingSource.DataSource = accountList;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetCard(object sender, EventArgs e)
        {


            try
            {
                var acc = _accountRepository.GetAccount(Session.CurrentUser);

                if (acc != null) 
                {
                    _view.DisplayName = acc.owner_name;
                    _view.AccountNumber = acc.account_number;
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
            var newCard = new users_bank_account
            {
                account_number = _view1.Card.CardNumber,
                owner_name = _view1.Card.Name.ToLower(),
                expiry_date = _view1.Card.ExpiryDate,
                email = _view1.Card.Email.ToLower(),
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
                    MessageBox.Show("make sure you fill the form correctly");



                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
