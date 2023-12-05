using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Models
{
    public class BankAccount
    {
        public string DisplayName { get; set; }
        public string AccountNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string Balance { get; set; }
        public string Income { get; set; }
        public string Expenses { get; set; }
        public string Savings { get; set; }
    }
}
