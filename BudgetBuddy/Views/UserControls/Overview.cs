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


        public string SendMoneyToAccountNumber { get; set; }
        public string SendMoneyToAccountName { get; set; }

        public decimal MoneyTransferAmount { get; set; }
        public Guna2DataGridView ContactDataGrid
        {
            get { return BankAccountDataGrid; }
            set { BankAccountDataGrid = value; }
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


            SendMoneyBtn.Click += delegate
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure to transfer to {SendMoneyToAccountName}", "Quick Transfer", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    MoneyTransferAmount = Decimal.Parse(MoneyTransferAmountTxtBox.Text);
                    SendEvent?.Invoke(this, EventArgs.Empty);


                }
                else if (dialogResult == DialogResult.No)
                {
                    // do nothing
                }






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

        public void SetBankListBindingSource(BindingSource bank, BindingSource transaction)
        {
            BankAccountDataGrid.DataSource = bank;
            TransactionDataGrid.DataSource = transaction;
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
