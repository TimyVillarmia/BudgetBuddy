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
        bool CreateAccount(user account);
        bool doesAccountExist(user account);
        bool LoginAccount(user account);
        bool RecoverAccount(user account);
        IQueryable GetBankAccountList(account account);
        bool AddCard(account card, string pin);
        account GetAccount(account account);
    }
}
