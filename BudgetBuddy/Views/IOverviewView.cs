using BudgetBuddy.Models;
using BudgetBuddy.Views.UserControls;
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


        bool HasAccount { get; set; }
        bool isSuccessful { get; set; }
        string SearchName { get; set; }

        BankAccount bankAccount { get; set; }


        void SetBankListBindingSource(BindingSource bank);

    }
}
