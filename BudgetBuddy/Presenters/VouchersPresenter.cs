using BudgetBuddy._Repositories;
using BudgetBuddy.Models;
using BudgetBuddy.Resources.Components;
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
            _view.LoadVouchersEvent += LoadVoucherPage;
            _view.LoadPointsEvent += LoadPoints;







        }

        private void LoadPoints(object sender, EventArgs e)
        {
            _view.user_points = $"My Points: {_accountRepository.GetPoints()}";
        }

        private void LoadVoucherPage(object sender, EventArgs e)
        {


            var vouchers = _accountRepository.GetVouchers();


            foreach (var item in vouchers)
            {
                _view.VoucherPanel.Controls.Add(new VoucherComponent(_view, item.voucher_id,
                                                                    item.voucher_name,
                                                                    item.required_points,
                                                                    item.voucher_type,
                                                                    item.voucher_reward,
                                                                    _accountRepository));
            }



        }


 
    }
}
