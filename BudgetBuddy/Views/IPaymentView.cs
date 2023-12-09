using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Views
{
    public interface IPaymentView
    {
        event EventHandler PayEvent;
        string PayToAccountNumber { get; set; }
        string PayToAccountName { get; set; }
        decimal MoneyTransferAmount { get; set; }


    }
}
