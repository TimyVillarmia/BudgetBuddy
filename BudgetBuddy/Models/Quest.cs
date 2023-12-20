using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Models
{
    public class Quest
    {
        public string quest_description { get; set; }
        public int quest_reward { get; set; }
        public DateTime quest_date { get; set; }
        public string status_name { get; set; }


    }
}
