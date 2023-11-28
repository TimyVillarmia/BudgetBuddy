using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Views
{
    public interface IRecovery1View
    {
        string Email { get; set; }
        bool isSuccessful { get; set; }


        event EventHandler RecoverAccountEvent;


    }
}
