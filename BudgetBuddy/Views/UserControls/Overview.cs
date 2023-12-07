using BudgetBuddy.Views.Charts;
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
using BudgetBuddy.Models;
using RestSharp.Extensions;

namespace BudgetBuddy.Views.UserControls
{
    public partial class Overview : UserControl, IOverviewView
    {
  

        public Dashboard1 Dashboard;
        private bool _HasAccount;
        private bool _isSuccessful;

        public event EventHandler LoadOverviewData;
        public event EventHandler SendEvent;
        public event EventHandler RequestEvent;
        public event EventHandler SearchAccountEvent;

        public Overview(Dashboard1 form)
        {
            InitializeComponent();
            Dashboard = form;
            AssociateAndRaiseViewEvents();

        }
        public bool HasAccount
        {
            get { return _HasAccount; }
            set { _HasAccount = value; }
        }

        public bool isSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }


        public string SearchName { get; set; }
        public string DisplayName { get; set; }
        public string AccountNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string Balance { get; set; }
        public string Income { get; set; }
        public string Expenses { get; set; }
        public string Savings { get; set; }

        private void AssociateAndRaiseViewEvents()
        {
            this.Enter += delegate
            {
                LoadOverviewData?.Invoke(this, EventArgs.Empty);
                ReloadForm();

            };

            this.Load += delegate
            {
                LoadOverviewData?.Invoke(this, EventArgs.Empty);
                ReloadForm();


            };


            SearchTxtBox.TextChanged += delegate
            {
                SearchName = SearchTxtBox.Text.ToLower();
                SearchAccountEvent?.Invoke(this, EventArgs.Empty);
                

            };



        }

        public Overview()
        {


        }

        public void ReloadForm()
        {
            if (HasAccount)
            {
                NoCardLbl.Visible = false;
                AddCardBtn.Visible = false;
                CardObject.Visible = true;

                PercentBalance.Visible = true;
                PercentExpenses.Visible = false;
                PercentIncome.Visible = true;
                PercentSavings.Visible = true;

                ExpiryDateLbl.Text = ExpiryDate;
                NameLbl.Text = DisplayName;
                CardNumberLbl.Text = AccountNumber;


            }
            else
            {
                CardObject.Visible = false;
                AddCardBtn.Visible = true;

                NoCardLbl.Visible = true;
                NoCardLbl.Location = new Point(20, 87);
                PercentBalance.Visible = false;
                PercentExpenses.Visible = false;
                PercentIncome.Visible = false;
                PercentSavings.Visible = false;

            }
        }


        private void AddCardBtn_Click(object sender, EventArgs e)
        {
            Dashboard.AddCard.BringToFront();
        }

        private void RightPanel_Enter(object sender, EventArgs e)
        {

        }

        public void SetBankListBindingSource(BindingSource bank)
        {
            BankAccountDataGrid.DataSource = bank;
        }
    }
}
