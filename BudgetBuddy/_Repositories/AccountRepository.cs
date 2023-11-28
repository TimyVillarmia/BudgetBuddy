using BudgetBuddy.Models;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
        public void CreateAccount(Models.Account account)
        {
            // insert code here
        }


        public bool LoginAccount(Models.Account account)
        {
            //insert login account linq code
            // check if the email and password matches from database
            // return true if login is success
            // otherwise, false
            var login = from acc in _db.Accounts
                        where acc.email == account.Email &&
                        acc.password == account.Password
                        select acc.email;

            bool result = (login.Count() == 0) ? false : true;

            return result;
        }

        public bool RecoverAccount(Models.Account account)
        {
            //insert recover account linq code
            // update the password from the database
            // return true if account recovery is success
            // otherwise, false
            return true;

        }


        public bool doesAccountExist(Models.Account account)
        {
            //insert check account exist linq code
            // check if email exist or not from the database
            // return true if account exists
            // otherwise, false
            var login = from acc in _db.Accounts
                        where acc.email == account.Email
                        select acc.email;

            bool result = (login.Count() == 0) ? false : true;

            return result;
        }




    }
}
