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
        protected DataClasses1DataContext _db;


        public AccountRepository(DataClasses1DataContext db) 
        { 
            _db = db;
        }



        public void CreateAccount(Models.Account account)
        {
     
        }


        public int LoginAccount(Models.Account account)
        {
            
            var login = from acc in _db.Accounts
                        where acc.email == account.Email &&
                        acc.password == account.Password
                        select acc;
            
            return login.Count();
        }


        public void UpdateAccount(Models.Account account)
        {

        }

        public IQueryable GetAll()
        {

            var result = from account in _db.Accounts select account;


            return result;
        }


    }
}
