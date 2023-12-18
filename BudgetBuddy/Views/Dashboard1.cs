using BudgetBuddy.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetBuddy.Presenters;
using BudgetBuddy.Models;
using BudgetBuddy.Repositories;
using Guna.UI2.WinForms;

namespace BudgetBuddy.Views
{
    public partial class Dashboard1 : Form, IDashboardView
    {
        public Dashboard1()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public Overview Overview { get; set; }
        public AddCard AddCard { get; set; }
        public Vouchers Voucher { get; set; }
        public Payments Payments { get; set; }
        public Budgeting Budgeting { get; set; }
        public Profile UserProfile { get; set; }
        public Guna2CirclePictureBox ProfileCircleBtn
        {
            get { return ProfileBtn; }
            set { ProfileBtn = value; }
        }

        public Guna2Panel DBPanel
        {
            get { return DashboardPanel; }
            set { DashboardPanel = value; }
        }

        public string Profile_Src { get; set; }

        public event EventHandler LoadProfileEvent;

        private void Dashboard1_Load(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            IAccountRepository accountRepository = new AccountRepository(db);

            
            Overview = new Overview(this)
            {
                Dock = DockStyle.Fill
            };
            UserProfile = new Profile(this)
            {
                Dock = DockStyle.Fill,
                
            };
            Voucher = new Vouchers(this)
            {
                Dock = DockStyle.Fill
            };
            Payments = new Payments()
            {
                Dock = DockStyle.Fill
            };
            Budgeting = new Budgeting()
            {
                Dock = DockStyle.Fill
            };


            AddCard = new AddCard(this)
            {
                Dock = DockStyle.Fill
            };
   
            IOverviewView overview = Overview;
            IProfileView profile = UserProfile;
            IVouchersView transactionsView = Voucher;
            IPaymentView paymentView = Payments;
            IAddCardView addcard = AddCard;
            IBudgetingView budgetingview = Budgeting;
            IDashboardView dashboardView = this;

            new OverviewPresenter(accountRepository, overview, addcard);
            new ProfilePresenter(accountRepository, profile);
            new VouchersPresenter(accountRepository, transactionsView);
            new PaymentPresenter(accountRepository, paymentView);
            new BudgetingPresenter(accountRepository, budgetingview);
            new DashboardPresenter(accountRepository, dashboardView);



            DashboardPanel.Controls.Add(Overview);
            //DashboardPanel.Controls.Add(Transactions);
            //DashboardPanel.Controls.Add(Payments);
            //DashboardPanel.Controls.Add(Budgeting);
            //DashboardPanel.Controls.Add(AddCard);

            Overview.Focus();
            OverviewBtn.PerformClick();

        }

        private void FormatBtn(Guna2Button button)
        {
            if (button.Checked)
            {
                button.ForeColor = Color.White;
                button.CustomBorderColor = Color.FromArgb(255, 137, 6);
                button.CustomBorderThickness = new Padding(0, 0, 0, 1);
            }
            else
            {
                button.ForeColor = Color.FromArgb(167, 169, 190);
                button.CustomBorderColor = Color.Transparent;
                button.CustomBorderThickness = new Padding(0, 0, 0, 0);
            }
  


        }

        private void AssociateAndRaiseViewEvents()
        {

            this.Load += delegate
            {

                string[] s = { "\\bin" };
                string appPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + @"\Resources\UserProfile\";


                LoadProfileEvent?.Invoke(this, EventArgs.Empty);


                if (Profile_Src != string.Empty)
                {

                    ProfileBtn.Image = new Bitmap(appPath + Profile_Src);
                }
                else
                {
                    ProfileBtn.Image = Properties.Resources.user;
                }
            };

            OverviewBtn.CheckedChanged += delegate
            {
                DashboardPanel.Controls.Clear();
                DashboardPanel.Controls.Add(Overview);


                //Overview.BringToFront();
                Overview.Focus();
                FormatBtn(OverviewBtn);

            };
            BudgetingBtn.CheckedChanged += delegate
            {
                DashboardPanel.Controls.Clear();
                DashboardPanel.Controls.Add(Budgeting);
                //Budgeting.BringToFront();
                Voucher.Focus();
                FormatBtn(BudgetingBtn);


            };
            VouchersBtn.CheckedChanged += delegate
            {
                DashboardPanel.Controls.Clear();
                DashboardPanel.Controls.Add(Voucher);
                //Transactions.BringToFront();
                Voucher.Focus();
                FormatBtn(VouchersBtn);


            };
            PaymentBtn.CheckedChanged += delegate
            {
                DashboardPanel.Controls.Clear();
                DashboardPanel.Controls.Add(Payments);
                //Payments.BringToFront();
                FormatBtn(PaymentBtn);


            };

            ProfileBtn.Click += delegate
            {
                DashboardPanel.Controls.Clear();
                DashboardPanel.Controls.Add(UserProfile);
            };

            



        }


    }
}
