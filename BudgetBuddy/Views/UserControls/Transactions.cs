using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetBuddy.Views;

namespace BudgetBuddy.Views.UserControls
{
    public partial class Transactions : UserControl, ITransactionsView
    {
        public Dashboard1 Dashboard;

        public Transactions(Dashboard1 dashboard1)
        {
            InitializeComponent();
            Dashboard = dashboard1;
            AssociateAndRaiseViewEvents();

        }

        private void AssociateAndRaiseViewEvents()
        {
            this.Load += delegate
            {
                LoadTransactions?.Invoke(this, EventArgs.Empty);
            };

            this.Enter += delegate
            {
                LoadTransactions?.Invoke(this, EventArgs.Empty);
            };


        }

     

        public Guna2DataGridView TransactionsGrid
        {
            get { return TransactionDataGrid; }
            set { TransactionDataGrid = value; }
        }

        public event EventHandler LoadTransactions;

        public void SetTransactionListBindingSource(BindingSource transaction)
        {
            TransactionDataGrid.DataSource = transaction;
        }

    }
}
