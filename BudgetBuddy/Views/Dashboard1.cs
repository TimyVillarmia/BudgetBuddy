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
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public Overview Overview { get; set; }
        public AddCard AddCard { get; set; }
        public Transactions Transactions { get; set; }

        private void Dashboard1_Load(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            IAccountRepository accountRepository = new AccountRepository(db);

            
            Overview = new Overview(this)
            {
                Dock = DockStyle.Fill
            };

            Transactions = new Transactions(this)
            {
                Dock = DockStyle.Fill
            };

            AddCard = new AddCard(this)
            {
                Dock = DockStyle.Fill
            };
   
            IOverviewView overview = Overview;
            ITransactionsView transactionsView = Transactions;
            IAddCardView addcard = AddCard;

            new OverviewPresenter(accountRepository, overview, addcard);
            new TransactionsPresenter(accountRepository, transactionsView);


            DashboardPanel.Controls.Add(Overview);
            DashboardPanel.Controls.Add(Transactions);
            DashboardPanel.Controls.Add(AddCard);

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

            OverviewBtn.CheckedChanged += delegate
            {

                Overview.BringToFront();
                Overview.Focus();
                FormatBtn(OverviewBtn);

            };
            StatsBtn.CheckedChanged += delegate
            {

                //Overview.BringToFront();
                FormatBtn(StatsBtn);


            };
            TransactionBtn.CheckedChanged += delegate
            {

                Transactions.BringToFront();
                Transactions.Focus();
                FormatBtn(TransactionBtn);


            };
            ReportsBtn.CheckedChanged += delegate
            {

                //Overview.BringToFront();
                FormatBtn(ReportsBtn);


            };

            SettingBtn.Click += delegate
            {

            };

            



        }

    }
}
