using BudgetBuddy.Models;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Presenters
{
    public class OverviewPresenter
    {
        // fields Dependency Injection
        private readonly IAccountRepository _accountRepository;
        private readonly IOverviewView _view;

        // constructor
        public OverviewPresenter(IAccountRepository accountRepository, IOverviewView view)
        {
            _accountRepository = accountRepository;
            _view = view;
            // subscribe the view's event to the presenter's event
            //_view.LoginAccountEvent += LoginAccount;


        }
    }
}
