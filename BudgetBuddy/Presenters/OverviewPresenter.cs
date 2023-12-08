using BudgetBuddy._Repositories;
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
        private IEnumerable<TransactionModel> transactionList;
        private BindingSource bankBindingSource;
        private BindingSource transactionBindingSource;


        // constructor
        public OverviewPresenter(IAccountRepository accountRepository, IOverviewView view, IAddCardView view1)
        {
            this.bankBindingSource = new BindingSource();
            this.transactionBindingSource = new BindingSource();


            _accountRepository = accountRepository;
            _view = view;
            _view1 = view1;



            // subscribe the view's event to the presenter's event
            _view.LoadOverviewData += GetCard;
            _view.SearchAccountEvent += SearchAccount;
            _view.SendEvent += SendMoneyTo;

            _view1.AddNewCardEvent += AddCardMethod;

            _view.SetBankListBindingSource(bankBindingSource, transactionBindingSource);
            LoadAllDataGridList();




        }

        private void SendMoneyTo(object sender, EventArgs e)
        {
            var createNewTransaction = new transaction
            {
                receiver_account_number = _view.SendMoneyToAccountNumber,
                transaction_type = "MoneyTransfer",
                transaction_name = "Send",
                amount = _view.MoneyTransferAmount,
                transaction_date = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"))
            };

            _accountRepository.CreateTransactions(createNewTransaction);
        }

        private async void LoadAllDataGridList()
        {
            accountList = await MetrobankRepository.GetAllAsync();
            bankBindingSource.DataSource = accountList; //Set data source.

            transactionList = _accountRepository.GetTransactionsList();
            transactionBindingSource.DataSource = transactionList; //Set data source.

            _view.ContactDataGrid.Columns[0].HeaderText = "Name";
            _view.ContactDataGrid.Columns[1].Visible = false;
        }

        private async void SearchAccount(object sender, EventArgs e)
        {

            
            try
            {

                bool emptyValue = string.IsNullOrWhiteSpace(_view.SearchName);

                if (emptyValue)
                {
                    accountList = await MetrobankRepository.GetAllAsync();


                }
                else
                {
                    var result = await MetrobankRepository.GetAllAsync();
                    accountList = result.Where(search => search.owner_name.ToLower().StartsWith(_view.SearchName)); 

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
                var acc = _accountRepository.GetBankAccount(Session.CurrentUser);

                if (acc != null) 
                {
                    _view.DisplayName = acc.OwnerName;
                    _view.AccountNumber = acc.CardNumber;
                    _view.ExpiryDate = acc.ExpiryDate.ToString("MM/yy");

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


            try
            {


                if (_accountRepository.AddCard(_view1.Card))
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
