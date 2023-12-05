using BudgetBuddy.Models;
using BudgetBuddy.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Views
{
    public interface IOverviewView
    {
        event EventHandler LoadOverviewData;
        event EventHandler SendEvent;
        event EventHandler RequestEvent;

        bool HasAccount { get; set; }
        string Balance { get; set; }
        string Income { get; set; }
        string Expenses { get; set; }
        string Savings { get; set; }
        bool isSuccessful { get; set; }

        Card card { get; set; }

    }
}
