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
using Guna.UI2.WinForms;
using BudgetBuddy._Repositories;
using System.Windows.Forms.DataVisualization.Charting;
using Guna.Charts.WinForms;

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
        public event EventHandler AddTodoEvent;

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


        public string SendMoneyToAccountNumber { get; set; }      

        public string SendMoneyToAccountName { get; set; }
        public string RequestMoneyToAccountName { get; set; }

        public decimal MoneyTransferAmount { get; set; }
        public Guna2DataGridView ContactDataGrid
        {
            get { return BankAccountDataGrid; }
            set { BankAccountDataGrid = value; }
        }

        public Guna2DataGridView RecentTransactions
        {
            get { return ToDoDataGrid; }
            set { ToDoDataGrid = value; }
        }

        public Guna2DataGridView ToDoList
        {
            get { return TransactionDataGrid; }
            set { TransactionDataGrid = value; }
        }
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
                LoadChart(gunaChart1);
                ReloadForm();


            };


            SearchTxtBox.TextChanged += delegate
            {
                SearchName = SearchTxtBox.Text.ToLower();
                SearchAccountEvent?.Invoke(this, EventArgs.Empty);


            };


            BankAccountDataGrid.SelectionChanged += delegate
            {
                if (BankAccountDataGrid.SelectedCells.Count > 0)
                {
                    int selectedrowindex = BankAccountDataGrid.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = BankAccountDataGrid.Rows[selectedrowindex];
                    string cellNumber = Convert.ToString(selectedRow.Cells["account_number"].Value);
                    string cellName = Convert.ToString(selectedRow.Cells["owner_name"].Value);

                    SelectAccountNumberLbl.Text = cellNumber;
                    SendMoneyToAccountNumber = cellNumber;
                    SendMoneyToAccountName = cellName;


                };

            };


            SendMoneyBtn.Click += delegate
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure to send {MoneyTransferAmountTxtBox.Text} to {SendMoneyToAccountName}", "Quick Transfer", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    MoneyTransferAmount = Decimal.Parse(MoneyTransferAmountTxtBox.Text);
                    SendEvent?.Invoke(this, EventArgs.Empty);
                    this.Focus();


                }
                else if (dialogResult == DialogResult.No)
                {
                    // do nothing
                }



            };

            RequestMoneyBtn.Click += delegate
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure to request to {MoneyTransferAmountTxtBox.Text} from {SendMoneyToAccountName}", "Quick Transfer", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    MoneyTransferAmount = Decimal.Parse(MoneyTransferAmountTxtBox.Text);
                    RequestEvent?.Invoke(this, EventArgs.Empty);
                    this.Focus();


                }
                else if (dialogResult == DialogResult.No)
                {
                    // do nothing
                }



            };

            AddTodoBtn.Click += delegate
            {



                AddTodoEvent?.Invoke(this, EventArgs.Empty);

            };
        }

        private void LoadChart(GunaChart doughnut)
        {
            string[] categories = { "Food", "Rent", "Bills","Subscription"};

            //Chart configuration
            doughnut.Title.Text = "Spending Acitivities";
            doughnut.Legend.Position = LegendPosition.Right;
            doughnut.XAxes.Display = false;
            doughnut.YAxes.Display = false;
        

            var r = new Random();
            int num = r.Next(10, 100);

            var dataset = new GunaDoughnutDataset();

            dataset.DataPoints.Add(categories[0], num);
            dataset.DataPoints.Add(categories[1], num);
            dataset.DataPoints.Add(categories[2], num);
            dataset.DataPoints.Add(categories[3], num);


            //Create a new dataset 


            //Add a new dataset to a chart.Datasets
            doughnut.Datasets.Add(dataset);

            //An update was made to re-render the chart
            doughnut.Update();
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
                BalanceLbl.Text = Balance;
                PercentIncome.Visible = true;

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
                PercentIncome.Visible = false;

            }
        }


        private void AddCardBtn_Click(object sender, EventArgs e)
        {
            Dashboard.AddCard.BringToFront();
        }

        private void RightPanel_Enter(object sender, EventArgs e)
        {

        }

        public void SetBankListBindingSource(BindingSource bank, BindingSource transaction, BindingSource todo)
        {
            BankAccountDataGrid.DataSource = bank;
            TransactionDataGrid.DataSource = transaction;
            ToDoDataGrid.DataSource = ToDoDataGrid;
        }

        private void MoneyTransferAmountTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
