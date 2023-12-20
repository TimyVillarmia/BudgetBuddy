using BudgetBuddy.Models;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BudgetBuddy.Resources.Components
{
    public partial class VoucherComponent : UserControl
    {
        public string VoucherName
        {
            get { return _voucher_name; }
        }
        public int RequiredPoints
        {
            get { return _required_points; }
        }
        public string VoucherType
        {
            get { return _voucher_type; }
        }
        public int VoucherReward
        {
            get { return _voucher_reward; }
        }

        private int _id;
        private string _voucher_name;
        private int _required_points;
        private string _voucher_type;
        private int _voucher_reward;

        private readonly IAccountRepository _accountRepository;
        private readonly IVouchersView _view;


        public VoucherComponent(IVouchersView view, int id, string voucher_name, int required_points, string voucher_type, int voucher_reward , IAccountRepository accountRepository)
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();


            _id = id;
            _voucher_name = voucher_name;
            _required_points = required_points;
            _voucher_type = voucher_type;
            _voucher_reward = voucher_reward;

            _accountRepository = accountRepository;
            _view = view;

        }

        private void AssociateAndRaiseViewEvents()
        {


            this.Load += delegate
            {
                voucher_name.Text = _voucher_name;
                required_points.Text = $"Required Points:{_required_points}";
                voucher_type.Text = _voucher_type;
                voucher_reward.Text = $"{_voucher_reward}%"; 



            };

            redeemBtn.Click += delegate
            {
                try
                {
                    var user_points = _accountRepository.GetPoints();


                    if (_required_points <= user_points)
                    {

                        _accountRepository.UpdatePoints(Convert.ToInt32(user_points) - _required_points);
                        _accountRepository.RedeemVoucher(_id);
                        MessageBox.Show("Voucher successfully redeemed");

                        _view.user_points = $"My Points: {_accountRepository.GetPoints()}";
                    }
                    else
                    {
                        MessageBox.Show("insufficient  Points");

                    }

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }


            };
        }
    }
}
