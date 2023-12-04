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
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string PIN { get; set; }
    }

}
