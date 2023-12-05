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
        public string Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Income { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Expenses { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Savings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ExpiryDate
        {
            get { return ExpiryDateLbl.Text; }
            set { ExpiryDateLbl.Text = value; }
        }
        public string CardNumber
        {
            get { return CardNumberLbl.Text; }
            set { CardNumberLbl.Text = value; }
        }
        public string Name
        {
            get { return NameLbl.Text; }
            set { NameLbl.Text = value; }
        }

        private void AssociateAndRaiseViewEvents()
        {
            this.Load += delegate
            {
                LoadOverviewData?.Invoke(this, EventArgs.Empty);

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
                    NameLbl.Text = Name;
                    CardNumberLbl.Text = CardNumber;


                }
                else
                {
                    CardObject.Visible = false;
                    AddCardBtn.Visible = true;

                    NoCardLbl.Visible = true;
                    NoCardLbl.Location = new Point(178, 24);
                    PercentBalance.Visible = false;
                    PercentExpenses.Visible = false;
                    PercentIncome.Visible = false;
                    PercentSavings.Visible = false;

                }
            };



        }

        public Overview()
        {


        }



        private void Overview_Load(object sender, EventArgs e)
        {

            //DoughnutChart doughnutChart = new DoughnutChart();

            //ChartPanel.Controls.Add(doughnutChart);
        }

        private void AddCardBtn_Click(object sender, EventArgs e)
        {
            Dashboard.AddCard.BringToFront();
        }

        private void RightPanel_Enter(object sender, EventArgs e)
        {

        }

    }
}
