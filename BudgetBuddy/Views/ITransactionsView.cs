using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Views
{
    public interface ITransactionsView
    {
        event EventHandler LoadTransactions;
        Guna2DataGridView TransactionsGrid { get; set; }
        void SetTransactionListBindingSource(BindingSource transaction);


    }
}
