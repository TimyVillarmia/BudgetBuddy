using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Views
{
    public interface IBudgetingView
    {

        GunaChart Doughnut { get; set; }
        GunaChart Line { get; set; }
    }
}
