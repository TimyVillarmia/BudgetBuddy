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
        bool AddCard(users_bank_account new_card);
        IEnumerable<users_bank_account> GetBankAccountExternal_ID(string email);
        IEnumerable<TransactionModel> GetTransactionsList();
        void UploadProfilePicture(string profile_src);
        user_detail GetProfile();
        bool UpdateProfile(user user, user_detail user_Detail);
        void CreateTransactions(transaction NewTransaction);
        bool UpdatePoints(int points);
        int? GetPoints();
        IEnumerable<voucher> GetVouchers();
        IEnumerable<quest> GetQuests();

        IEnumerable<VoucherModel> GetUser_Vouchers();
        void RedeemVoucher(int voucher_id);



    }
}
