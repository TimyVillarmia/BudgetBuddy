using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Views
{
    public interface ISignInView
    {
        string Email { get; set; }  
        string Password { get; set; }
        bool isSuccessful { get; set; }
        string test { get; set; }

        event EventHandler LoginAccountEvent;

    }
}
