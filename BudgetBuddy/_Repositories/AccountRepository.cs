using BudgetBuddy._Repositories;
using BudgetBuddy.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static BudgetBuddy._Repositories.Encryption;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

                    var getID = (from u in _db.users
                                 where u.email == user.email
                                 select u.user_id).FirstOrDefault();

                    user_Detail.user_id = getID;
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


        public int? GetPoints()
        {
            try
            {
                var points = (from ud in _db.user_details
                                      join u in _db.users on ud.user_id equals u.user_id
                                      where u.email == Session.CurrentUser
                                      select ud.user_points).First();




                return points;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;


            }


        }


        public bool UpdatePoints(int points)
        {

            try
            {
                var update_details = (from ud in _db.user_details
                                      join u in _db.users on ud.user_id equals u.user_id
                                      where u.email == Session.CurrentUser
                                      select ud).FirstOrDefault();


                update_details.user_points += points;

                _db.SubmitChanges();

                return true;
            }
            catch
            {
                return false;

            }


 
        }

        public bool UpdateProfile(user user, user_detail user_Detail)
        {


            try
            {

                HashSalt hashSalt = GenerateSaltedHash(user.password_hash);


                var get_user = (from u in _db.users
                             where u.email == Session.CurrentUser
                             select u).FirstOrDefault();

                var update_details = (from ud in _db.user_details
                                      where ud.user_id == get_user.user_id
                                      select ud).FirstOrDefault();

                get_user.password_hash = hashSalt.Hash;
                get_user.password_salt = hashSalt.Salt;

                update_details.first_name = user_Detail.first_name;
                update_details.last_name = user_Detail.last_name;


                _db.SubmitChanges();

                return true;

            }
            catch (Exception e)
            {
                throw e;
                //return false;
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

  
        public IEnumerable<users_bank_account> GetBankAccountExternal_ID(string email)
        {
            try
            {
                var queryjoin = (from ba in _db.users_bank_accounts
                                 join user in _db.users on ba.user_id equals user.user_id
                                 where user.email == Session.CurrentUser
                                 select ba).ToList();

                if (queryjoin.Any())
                {
                    return queryjoin;

                }
                else
                {
                    return null;

                }







            }
            catch (Exception e)
            {
                throw e;
            }


        }

        public bool AddCard(users_bank_account new_card)
        {
            try
            {



                var queryjoin = (from user in _db.users
                                 where user.email == Session.CurrentUser
                                 select user).FirstOrDefault();

                new_card.user_id = queryjoin.user_id;


                _db.users_bank_accounts.InsertOnSubmit(new_card);
                _db.SubmitChanges();

                return true;
            }
            catch
            {
                return false;

                throw new Exception("The card has already added to another account");
            }

        }

        public IEnumerable<TransactionModel> GetTransactionsList()
        {


            var queryjoin = (from t in _db.transactions
                             join ba in _db.users_bank_accounts on t.users_bank_account_id equals ba.users_bank_account_id
                             join u in _db.users on ba.user_id equals u.user_id
                             where u.email == Session.CurrentUser
                             select new TransactionModel
                             {
                                 Receiver = t.receiver_name,
                                 Type = t.transaction_type,
                                 TransactionName = t.transaction_name,
                                 date = t.transaction_date,
                                 amount = t.amount
                             }).ToList();



            return queryjoin;
        }


        public void UploadProfilePicture(string profile_src)
        {
            try
            {
                var queryjoin = (from ud in _db.user_details
                                 join user in _db.users on ud.user_id equals user.user_id
                                 where user.email == Session.CurrentUser
                                 select ud).FirstOrDefault();

                queryjoin.profile_src = profile_src;

                _db.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }


        public void CreateTransactions(transaction NewTransaction)
        {
            try
            {


                var queryBA = (from t in _db.users_bank_accounts
                               join u in _db.users on t.user_id equals u.user_id
                               where u.email == Session.CurrentUser
                               select t).FirstOrDefault();

                if (queryBA == null)
                {
                    MessageBox.Show("Make sure you have added a bank acount into your account");
                }
                else
                {

                    NewTransaction.users_bank_account_id = queryBA.users_bank_account_id;

                    _db.transactions.InsertOnSubmit(NewTransaction);
                    _db.SubmitChanges();
                }


            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public user_detail GetProfile()
        {
            var profile = (from ud in _db.user_details
                           join u in _db.users on ud.user_id equals u.user_id
                           where u.email == Session.CurrentUser.ToString()
                           select ud).FirstOrDefault();

            if (profile != null)
            {
                return profile;

            }
            else
            {
                return null;
            }

        }
    }
}
