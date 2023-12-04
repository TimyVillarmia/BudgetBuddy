using BudgetBuddy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Views
{
    public interface IAddCardView
    {
        event EventHandler AddNewCardEvent;
        bool isSuccessful { get; set; }
        Card Card { get; set; }

    }
}
