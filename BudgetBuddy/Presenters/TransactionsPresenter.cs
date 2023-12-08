using BudgetBuddy._Repositories;
using BudgetBuddy.Models;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Presenters
{
    public class TransactionsPresenter
    {
        private readonly IAccountRepository _accountRepository;
        private readonly ITransactionsView _view;

        private IEnumerable<TransactionModel> transactionList;

        private BindingSource transactionBindingSource;


        // constructor
        public TransactionsPresenter(IAccountRepository accountRepository, ITransactionsView view)
        {
            this.transactionBindingSource = new BindingSource();


            _accountRepository = accountRepository;
            _view = view;



            // subscribe the view's event to the presenter's event
            _view.LoadTransactions += LoadTransactionsDate;



            _view.SetTransactionListBindingSource(transactionBindingSource);
            LoadAllDataGridList();




        }

        private void LoadAllDataGridList()
        {


            transactionList = _accountRepository.GetTransactionsList();
            transactionBindingSource.DataSource = transactionList; //Set data source.



            _view.TransactionsGrid.Columns[0].HeaderText = "Transaction";
            _view.TransactionsGrid.Columns[0].HeaderText = "Type";
            _view.TransactionsGrid.Columns[0].HeaderText = "Date";
            _view.TransactionsGrid.Columns[0].HeaderText = "Amount";
        }

        private void LoadTransactionsDate(object sender, EventArgs e)
        {

            transactionList = _accountRepository.GetTransactionsList();
            transactionBindingSource.DataSource = transactionList; //Set data source.
        }
    }
}
