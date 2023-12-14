using BudgetBuddy._Repositories;
using BudgetBuddy.Models;
using BudgetBuddy.Views;
using BudgetBuddy.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
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
            _view.RequestEvent += RequestMoneyFrom;

            _view1.AddNewCardEvent += AddCardMethod;

            _view.SetBankListBindingSource(bankBindingSource, transactionBindingSource, todoBindingSource);
            LoadAllDataGridList();




        }

        private void RequestMoneyFrom(object sender, EventArgs e)
        {
            var createNewTransaction = new transaction
            {
                receiver_name = _view.owner_name,
                sender_name = _view.SendMoneyToAccountName,
                transaction_type = "MoneyTransfer",
                transaction_name = "Request",
                amount = _view.MoneyTransferAmount,
                transaction_date = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"))
            };

            _accountRepository.CreateTransactions(createNewTransaction);
        }

        private void SendMoneyTo(object sender, EventArgs e)
        {
            var createNewTransaction = new transaction
            {
                receiver_name = _view.SendMoneyToAccountName,
                sender_name = _view.owner_name,
                transaction_type = "MoneyTransfer",
                transaction_name = "Send",
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



        public async Task LoadCheckingAccount(string external_id)
        {
            if (external_id == null)
            {
                _view.HasChecking = false;


            }
            else
            {
                var checking_account = await MetrobankRepository.GetAccountFromJSONServer(external_id);

                _view.owner_name = checking_account.owner_name;
                _view.account_number = checking_account.account_number;
                _view.expiry_date = checking_account.expiry_date.ToString("MM/yy");

                _view.checking_balance = $"₱ {checking_account.current_balance.ToString():n}";

    

                
            }

         
        }

        public async Task LoadSavingsAccount(string external_id)
        {
            if (external_id == null)
            {
                _view.HasSavings = false;

            }
            else
            {
                var savings_account = await MetrobankRepository.GetAccountFromJSONServer(external_id);


                var savings_bal = savings_account.current_balance.ToString() ?? "No Savings Account";

                _view.savings_balance = $"₱ {savings_bal:n}";


            }


        }

        private void LoadOverview(object sender, EventArgs e)
        {


            try
            {
                
                var external_ID = _accountRepository.GetBankAccountExternal_ID(Session.CurrentUser);

                transactionList = _accountRepository.GetTransactionsList();
                transactionBindingSource.DataSource = transactionList; //Set data source.


                if (external_ID != null) 
                {

                    var checking = external_ID.Where(check => check.account_type == "checking").FirstOrDefault();
                    var savings = external_ID.Where(saving => saving.account_type == "savings").FirstOrDefault();
                    _view.HasChecking = (checking == null) ? false : true;
                    _view.HasChecking = (savings == null) ? false : true;


                    var task = Task.Run(async () =>
                    {
                        var checking_account = await MetrobankRepository.GetAccountFromJSONServer(checking.external_id);

                        _view.owner_name = checking_account.owner_name;
                        _view.account_number = checking_account.account_number;
                        _view.expiry_date = checking_account.expiry_date.ToString("MM/yy");

                        _view.checking_balance = $"₱ {checking_account.current_balance.ToString():n}";
                    });
                    task.Wait();

                    while (!task.IsCompleted)
                    {
                        _view.Loader.Visible = true; 
                        _view.Loader.Location = new Point(183, 158);
                        _view.checking_balance = "Loading...";

                    }
                    _view.Loader.Visible = false;
                    _view.HasChecking = true;
                    //_ = LoadSavingsAccount(savings.external_id);


                }
                else
                {
                    _view.HasChecking = false;
                    _view.HasSavings = false;

                }

            }
            catch(Exception ex)
            {
                throw ex;
            }



        }


        private void AddCardMethod(object sender, EventArgs e)
        {


            try
            {


                if (_accountRepository.AddCard(_view1.new_account))
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
