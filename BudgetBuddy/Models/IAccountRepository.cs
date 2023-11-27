using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Models
{
    public interface IAccountRepository
    {
        void CreateAccount(Account account);
        void UpdateAccount(Account account);
        string LoginAccount(Account acount);
        int RecoverAccount(Models.Account account);
    }
}
