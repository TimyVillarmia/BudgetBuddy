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

        private void AssociateAndRaiseViewEvents()
        {
            this.Enter += delegate
            {
                LoadOverviewData?.Invoke(this, EventArgs.Empty);

                if (HasAccount)
                {
                    NoCardLbl.Visible = false;
                    CardObject.Visible = true;
                    PercentBalance.Visible = true;
                    PercentExpenses.Visible = false;
                    PercentIncome.Visible = true;
                    PercentSavings.Visible = true;

                }
                else
                {
                    NoCardLbl.Visible = true;
                    CardObject.Visible = false;
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

            DoughnutChart doughnutChart = new DoughnutChart();

            ChartPanel.Controls.Add(doughnutChart);
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
