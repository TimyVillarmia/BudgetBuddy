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
        private IEnumerable<TodoModel> todoList;


        private BindingSource bankBindingSource;
        private BindingSource transactionBindingSource;
        private BindingSource todoBindingSource;


        // constructor
        public OverviewPresenter(IAccountRepository accountRepository, IOverviewView view, IAddCardView view1)
        {
            this.bankBindingSource = new BindingSource();
            this.transactionBindingSource = new BindingSource();
            this.todoBindingSource = new BindingSource();


            _accountRepository = accountRepository;
            _view = view;
            _view1 = view1;



            // subscribe the view's event to the presenter's event
            _view.LoadOverviewData += LoadOverview;
            _view.SearchAccountEvent += SearchAccount;
            _view.SendEvent += SendMoneyTo;

            _view1.AddNewCardEvent += AddCardMethod;

            _view.SetBankListBindingSource(bankBindingSource, transactionBindingSource, todoBindingSource);
            LoadAllDataGridList();




        }

        private void SendMoneyTo(object sender, EventArgs e)
        {
            var createNewTransaction = new transaction
            {
                receiver_account_number = _view.SendMoneyToAccountNumber,
                transaction_type = "MoneyTransfer",
                transaction_name = _view.SendMoneyToAccountName,
                amount = _view.MoneyTransferAmount,
                transaction_date = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"))
            };

            _accountRepository.CreateTransactions(createNewTransaction);
        }

        private async void LoadAllDataGridList()
        {



            transactionList = _accountRepository.GetTransactionsList();
            transactionBindingSource.DataSource = transactionList; //Set data source.

            todoList = _accountRepository.GetTodoList();
            transactionBindingSource.DataSource = todoList; //Set data source.

            var result = await MetrobankRepository.GetAllAsync();

            accountList = result.ToList();
            bankBindingSource.DataSource = accountList; //Set data source.

            _view.ContactDataGrid.Columns[0].HeaderText = "Name";
            _view.ContactDataGrid.Columns[1].Visible = false;




            //MessageBox.Show($"{_view.RecentTransactions.Columns.Count}");
            //_view.RecentTransactions.Columns[0].HeaderText = "Transaction";
            //_view.RecentTransactions.Columns[1].HeaderText = "Type";
            //_view.RecentTransactions.Columns[2].HeaderText = "Date";
            //_view.RecentTransactions.Columns[3].HeaderText = "Amount";
        }

        private async void SearchAccount(object sender, EventArgs e)
        {
            var asyncResult = await MetrobankRepository.GetAllAsync();


            try
            {

                bool emptyValue = string.IsNullOrWhiteSpace(_view.SearchName);

                if (emptyValue)
                {
                    accountList = asyncResult;

                }
                else
                {
                    accountList = asyncResult.Where(search => search.owner_name.ToLower().StartsWith(_view.SearchName)); 

                }

                bankBindingSource.DataSource = accountList;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void LoadOverview(object sender, EventArgs e)
        {


            try
            {

                var acc = _accountRepository.GetBankAccount(Session.CurrentUser);
                var asyncResult = await MetrobankRepository.GetBalance(acc.CardNumber);

                transactionList = _accountRepository.GetTransactionsList();
                transactionBindingSource.DataSource = transactionList; //Set data source.

                if (acc != null) 
                {



                    _view.DisplayName = acc.OwnerName;
                    _view.AccountNumber = acc.CardNumber;
                    _view.ExpiryDate = acc.ExpiryDate.ToString("MM/yy");
                    _view.Balance = $"₱ {asyncResult.ToString():n}";

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
