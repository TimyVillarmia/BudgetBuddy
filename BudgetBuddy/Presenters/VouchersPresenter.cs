using BudgetBuddy._Repositories;
using BudgetBuddy.Models;
using BudgetBuddy.Views;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Presenters
{
    public class VouchersPresenter
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IVouchersView _view;




        // constructor
        public VouchersPresenter(IAccountRepository accountRepository, IVouchersView view)
        {


            _accountRepository = accountRepository;
            _view = view;



            // subscribe the view's event to the presenter's event
            _view.LoadTransactions += LoadAllDataGridList;



            LoadAllDataGridList();




        }

        private void LoadAllDataGridList()
        {


   
        }

        private void LoadAllDataGridList(object sender, EventArgs e)
        {




        }


 
    }
}
