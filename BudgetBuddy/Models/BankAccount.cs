using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Models
{
    public class BankAccount
    {
        public string account_number { get; set; }
        public string account_type { get; set; }
        public decimal current_balance { get; set; }
        public string owner_name { get; set; }
        public DateTime open_date { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }
        public string PIN { get; set; }
        public DateTime expiry_date { get; set; }
        public string email { get; set; }

    }
}
