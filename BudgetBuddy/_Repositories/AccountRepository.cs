using BudgetBuddy._Repositories;
using BudgetBuddy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BudgetBuddy._Repositories.Encryption;

namespace BudgetBuddy.Repositories
{
    public class AccountRepository : BaseRepository, IAccountRepository
    {
        //fields
        protected DataClasses1DataContext _db;

        // constructor
        public AccountRepository(DataClasses1DataContext db)
        {
            _db = db;
        }


        // methods
        public bool CreateAccount(user user, user_detail user_Detail)
        {
            //insert create account linq code
            // check if the email is already exist in the database
            // if email is doesn't exist proceed to create account and return true
            // otherwise, false
            try
            {
                HashSalt hashSalt = GenerateSaltedHash(user.password_hash);

                user.password_salt = hashSalt.Salt;
                user.password_hash = hashSalt.Hash;

                // check first if account exist
                if (!doesAccountExist(user))
                {
                    _db.users.InsertOnSubmit(user);
                    _db.SubmitChanges();
                    user_Detail.user_id = user.user_id;
                    _db.user_details.InsertOnSubmit(user_Detail);
                    _db.SubmitChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }


        public bool LoginAccount(user account)
        {


            //insert login account linq code

            var login = (from acc in _db.users
                         where acc.email == account.email
                         select acc).Single();

            //Compare the hash of the given password with the hash from the database.
            //If they match, the password is correct. Otherwise, the password is incorrect.
            if (Encryption.VerifyPassword(account.password_hash, login.password_hash, login.password_salt))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool RecoverAccount(user account)
        {
            //insert recover account linq code
            // update the password from the database
            // return true if account recovery is success
            // otherwise, false
            try
            {
                var recover = (from acc in _db.users
                               where account.email == account.email
                               select acc).First();


                HashSalt hashSalt = GenerateSaltedHash(account.password_hash);

                recover.password_salt = hashSalt.Salt;
                recover.password_hash = hashSalt.Hash;

                _db.SubmitChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }


        public bool doesAccountExist(user account)
        {
            //insert check account exist linq code
            // check if email exist or not from the database
            var login = from acc in _db.users
                        where acc.email == account.email
                        select acc;

            // return true if account exists
            // otherwise, false
            return login.Any();
        }

        public IEnumerable<Users> GetBankAccountList()
        {
            var query = (from list in _db.Metrobanks
                         select list).ToList();


            var selected = query.Select(sel => new Users { DisplayName = sel.owner_name, AccountNumber = sel.account_number });

            return selected;
        }


        public users_bank_account GetAccount(string email)
        {
            var accountlist = (from acc in _db.users_bank_accounts
                               where acc.email == email
                               select acc).FirstOrDefault();


            return accountlist;

        }

        public bool AddCard(users_bank_account card, string pin)
        {
            try
            {
                // query from the metrobank table *acts like an API*
                var checkBank = (from bank_account in _db.Metrobanks
                                 where bank_account.owner_name == card.owner_name &&
                                 bank_account.PIN == pin &&
                                 bank_account.expiry_date == card.expiry_date &&
                                 bank_account.email == card.email
                                 select bank_account).First();

                // insert bank account associated with users
                card.email = checkBank.email.ToLower();
                card.account_number = checkBank.account_number;
                card.account_type = checkBank.account_type;
                card.owner_name = checkBank.owner_name.ToLower();
                card.expiry_date = checkBank.expiry_date;

                _db.users_bank_accounts.InsertOnSubmit(card);
                _db.SubmitChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
}
