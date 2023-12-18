using System;

namespace BudgetBuddy.Views
{
    public interface IDashboardView
    {
        string Profile_Src { get; set; }
        event EventHandler LoadProfileEvent;
    }
}