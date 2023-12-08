using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Models
{
    public class Card
    {
        public string CardNumber { get; set; }
        public string OwnerName { get; set; }
        public DateTime ExpiryDate { get; set; }
    }

}
