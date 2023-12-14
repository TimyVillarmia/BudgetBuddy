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
        event EventHandler LoadEvent;

        string Email { get; set; }
        string Sender_number { get; set; }
        string Sender_name { get; set; }
        bool hasAccount { get; set; }
        string PayToAccountNumber { get; set; }
        string PayToAccountName { get; set; }
        decimal MoneyTransferAmount { get; set; }
        string TransactionName { get; set; }

    }
}
