using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Views
{
    public interface IAccountView
    {
        string AccountId { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }
    }
}
