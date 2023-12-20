using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetBuddy.Views;

namespace BudgetBuddy.Views.UserControls
{
    public partial class Vouchers : UserControl, IVouchersView
    {
        public Dashboard1 Dashboard;

        public string user_points { get; set; }
        FlowLayoutPanel IVouchersView.VoucherPanel
        {
            get { return voucherPanel; }
            set { voucherPanel = value; }
        }

        public Vouchers(Dashboard1 dashboard1)
        {
            InitializeComponent();
            Dashboard = dashboard1;
            AssociateAndRaiseViewEvents();

        }

        private void AssociateAndRaiseViewEvents()
        {
            this.Load += delegate
            {
                voucherPanel.Controls.Clear();
                LoadPointsEvent?.Invoke(this, EventArgs.Empty);
                LoadVouchersEvent?.Invoke(this, EventArgs.Empty);
                MyPoints.Text = "My points: " + user_points;

            };




        }

     


        public event EventHandler LoadVouchersEvent;
        public event EventHandler LoadPointsEvent;


    }
}
