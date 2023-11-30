using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetBuddy.Models;

namespace BudgetBuddy.Repositories
{
    public abstract class BaseRepository
    {
        protected DataClasses1DataContext db;
    }
}
