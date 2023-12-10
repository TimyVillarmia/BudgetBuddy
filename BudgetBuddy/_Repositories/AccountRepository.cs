using BudgetBuddy._Repositories;
using BudgetBuddy.Models;
using System;
using System.Collections;
using System.Collections.Generic;
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

  
        public IEnumerable<users_bank_account> GetBankAccount(string email)
        {
            try
            {
                var queryjoin = (from ba in _db.users_bank_accounts
                                 join user in _db.users on ba.user_id equals user.user_id
                                 where user.email == Session.CurrentUser
                                 select ba).ToList();

                if (queryjoin == null)
                {
                    return null;
                }
                else
                {
                    return queryjoin;

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
                                 TransactionName = t.transaction_name,
                                 Type = t.transaction_type,
                                 date = t.transaction_date,
                                 amount = $"₱ {t.amount}"
                             }).ToList();



            return queryjoin;
        }


        public IEnumerable<TodoModel> GetTodoList()
        {


            //var queryjoin = (from todo in _db.user_todos
            //                 join user in _db.users on todo.user_id equals user.user_id
            //                 where user.email == Session.CurrentUser
            //                 select new TodoModel
            //                 {
            //                     TodoName = todo.todo_name,
            //                     TodoDate = todo.date.ToString("yyyy/MM/dd")
            //                 }).ToList();



            //return queryjoin;
            return null;
        }

        public void CreateTodo(user_todo newTodo)
        {

            //var queryID = (from user in _db.users
            //                 where user.email == Session.CurrentUser
            //                 select user).FirstOrDefault();


            //newTodo.user_id = queryID.user_id;

            //_db.user_todos.InsertOnSubmit(newTodo);
            //_db.SubmitChanges();



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

    }
}
