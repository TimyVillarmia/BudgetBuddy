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
        Card GetBankAccount(string email);
        IEnumerable<TransactionModel> GetTransactionsList();
        void CreateTransactions(transaction NewTransaction);
    }
}
