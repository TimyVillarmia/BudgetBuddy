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
        event EventHandler AddNewCardEvent;
        event EventHandler SendEvent;
        event EventHandler RequestEvent;




    }
}
