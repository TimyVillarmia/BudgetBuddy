﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Models
{
    public class TransactionModel
    {
        public string TransactionName { get; set; }
        public string Type { get; set; }
        public DateTime date { get; set; }
        public decimal amount { get; set; }
    }
}
