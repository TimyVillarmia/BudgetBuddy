using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetBuddy.Models;

namespace BudgetBuddy.Models
{
    public interface IAccountRepository
    {
        bool CreateAccount(user user, user_detail user_Detail);
        bool doesAccountExist(user account);
        bool LoginAccount(user user);
        bool RecoverAccount(user account);
        bool AddCard(users_bank_account card);
        users_bank_account GetBankAccount(string email);
        IEnumerable<transaction> GetTransactionsList(string account_number);
        void CreateTransactions(transaction transaction);
    }
}
