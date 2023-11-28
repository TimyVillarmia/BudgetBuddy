using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Models
{
    public interface IAccountRepository
    {
        void CreateAccount(Account account);
        bool doesAccountExist(Account account);
        string LoginAccount(Account acount);
        bool RecoverAccount(Models.Account account);
    }
}
