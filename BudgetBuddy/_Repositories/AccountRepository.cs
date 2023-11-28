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


        public string LoginAccount(Models.Account account)
        {
            
            var login = from acc in _db.Accounts
                        where acc.email == account.Email &&
                        acc.password == account.Password
                        select acc.email;
            
            
            return login.FirstOrDefault();
        }

        public bool RecoverAccount(Models.Account account)
        {
            //insert recover account linq code
            // return true if account recovery is success
            // otherwise, false
            return true;

        }


        public bool doesAccountExist(Models.Account account)
        {
            var login = from acc in _db.Accounts
                        where acc.email == account.Email
                        select acc.email;

            bool result = (login.Count() == 0) ? false : true;

            return result;
        }




    }
}
