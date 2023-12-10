﻿using BudgetBuddy.Models;
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

        //Checking & Savings Account Fields
        string account_number { get; set; }
        string account_type { get; set; }
        string checking_balance { get; set; }
        string savings_balance { get; set; }
        string owner_name { get; set; }
        string expiry_date { get; set; }


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
