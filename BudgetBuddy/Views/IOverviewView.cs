using BudgetBuddy.Models;
using BudgetBuddy.Views.UserControls;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Views
{
    public interface IOverviewView
    {
        event EventHandler LoadOverviewData;
        event EventHandler SendEvent;
        event EventHandler RequestEvent;
        event EventHandler SearchAccountEvent;
        event EventHandler AddTodoEvent;

        bool HasAccount { get; set; }
        bool isSuccessful { get; set; }
        string SearchName { get; set; }

        string DisplayName { get; set; }
        string AccountNumber { get; set; }
        string ExpiryDate { get; set; }
        string Balance { get; set; }
        string Income { get; set; }
        string Expenses { get; set; }
        string Savings { get; set; }
        string SendMoneyToAccountNumber { get; set; }
        string SendMoneyToAccountName { get; set; }
        string RequestMoneyToAccountName { get; set; }
        decimal MoneyTransferAmount { get; set; }

        Guna2DataGridView ContactDataGrid { get; set; }
        Guna2DataGridView RecentTransactions { get; set; }
        Guna2DataGridView ToDoList { get; set; }

        void SetBankListBindingSource(BindingSource bank, BindingSource transaction, BindingSource todo);

    }
}
