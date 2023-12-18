using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.Charts.WinForms;
using System.Collections.Generic;
using System.Collections;

namespace BudgetBuddy.Views.UserControls
{
    public partial class Overview : UserControl, IOverviewView
    {
  

        public Dashboard1 Dashboard;
        private bool _isSuccessful;


        public event EventHandler LoadOverviewData;
        public event EventHandler SendEvent;
        public event EventHandler RequestEvent;
        public event EventHandler SearchAccountEvent;
        public event EventHandler EarnPointsEvent;

        
        public Overview(Dashboard1 form)
        {
            InitializeComponent();
            Dashboard = form;
            AssociateAndRaiseViewEvents();
            MissionLayout.FlowDirection = FlowDirection.TopDown;
            MissionLayout.WrapContents = false;
            MissionLayout.AutoScroll = true;

            LoaderObj.Visible = false;
            NoCardLbl.Visible = true;
            NoCardLbl.Location = new Point(20, 87);
            AddCardBtn.Visible = true;
            CardObject.Visible = false;

            PercentBalance.Visible = false;
            BalanceLbl.Text = "No Checking Account";
            SavingsLbl.Text = "No Savings Account";
            PercentSavings.Visible = false;

            PercentBalance.Visible = false;
            PercentSavings.Visible = false;

        }
        public bool HasChecking { get; set; }
        public bool HasSavings { get; set; }

        public bool isSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }
        public string SearchName { get; set; }

        public string account_number { get; set; }
        public string account_type { get; set; }
        public string checking_balance { get; set; }
        public string savings_balance { get; set; }
        public string owner_name { get; set; }
        public string expiry_date { get; set; }

        public string user_points
        {
            get { return PointsLbl.Text; }
            set {  PointsLbl.Text = value; }
        }

        public string SendMoneyToAccountNumber { get; set; }      
        public string SendMoneyToAccountName { get; set; }
        public string RequestMoneyToAccountName { get; set; }

        public decimal MoneyTransferAmount { get; set; }
        public Guna2DataGridView ContactDataGrid
        {
            get { return BankAccountDataGrid; }
            set { BankAccountDataGrid = value; }
        }

 



        public Guna2ProgressIndicator Loader
        {
            get { return LoaderObj; }
            set { LoaderObj = value; }
        }
        public GunaChart Doughnut
        {
            get { return gunaChart1; }
            set { gunaChart1 = value; }
        }

        private void AssociateAndRaiseViewEvents()
        {
            this.Enter += delegate
            {

                LoadOverviewData?.Invoke(this, EventArgs.Empty);
                ReloadFormChecking();
                ReloadFormSavings();
            };

            this.Load += delegate
            {
                
                LoadAllMisson();
                LoadOverviewData?.Invoke(this, EventArgs.Empty);
                EarnPointsEvent?.Invoke(this, EventArgs.Empty);
                ReloadFormChecking();
                ReloadFormSavings();





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

                if (int.Parse(MoneyTransferAmountTxtBox.Text) <= 5)
                {
                    MessageBox.Show("Amount must be greater than or equal to 5");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure to send {MoneyTransferAmountTxtBox.Text} to {SendMoneyToAccountName}", "Quick Transfer", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        MoneyTransferAmount = Decimal.Parse(MoneyTransferAmountTxtBox.Text);
                        SendEvent?.Invoke(this, EventArgs.Empty);
                        EarnPointsEvent?.Invoke(this, EventArgs.Empty);

                        this.Focus();


                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        // do nothing
                    }

                }



            };

            RequestMoneyBtn.Click += delegate
            {
                if (int.Parse(MoneyTransferAmountTxtBox.Text) <= 5)
                {
                    MessageBox.Show("Amount must be greater than or equal to 5");
                }
                else
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
                }
  



            };

       


        }



        private void LoadAllMisson()
        {
            Dictionary<string, string> mission_list = new Dictionary<string,string>
            {
                { "Make a qualifying transaction of P200 or more in a single day.", "100" },
                { "Successfully transfer $100 or more to your savings account for 7 consecutive days.", "100" },
                {"Stick to your budget for the entire month, logging all expenses and staying within budget limits.", "100" },
                { "Invest $500 or more in a diversified portfolio within the app's investment platform.", "100" },
                { "Complete three educational modules or articles on personal finance within the app.", "100" },
            };


            foreach (KeyValuePair<string, string> entry in mission_list)
            {
                MissionLayout.Controls.Add(new MissionComponent(entry.Key, entry.Value));
            }
    

        }

        private void ReloadFormSavings()
        {
            if (HasSavings)
            {
                AddCardBtn.Visible = (HasChecking && HasSavings) ? false : true;
                SavingsCardLbl.Text = HasSavings == true ? "Total Savings" : "No Savings Account";

                PercentBalance.Visible = true;
                SavingsLbl.Text = savings_balance ?? " ";
                PercentSavings.Visible = true;



            }
            else
            {
                AddCardBtn.Visible = (HasChecking && HasSavings) ? false : true;
                SavingsCardLbl.Text = HasSavings == true? "Total Savings" : "No Savings Account";

                SavingsLbl.Text = savings_balance ?? " ";
                PercentSavings.Visible = false;

                PercentSavings.Visible = false;

            }
        }


        private void ReloadFormChecking()
        {
            if (HasChecking)
            {
                NoCardLbl.Visible = false;
                AddCardBtn.Visible = (HasChecking && HasSavings) ? false : true;
                CardObject.Visible = true;

                PercentBalance.Visible = true;
                BalanceLbl.Text = checking_balance ?? " ";
                PercentSavings.Visible = true;

                ExpiryDateLbl.Text = expiry_date;
                NameLbl.Text = owner_name;
                CardNumberLbl.Text = account_number;
                BalanceCardLbl.Text = HasChecking == true ? "Total Balance" : "No Checking Account";


            }
            else
            {
                NoCardLbl.Visible = true;
                NoCardLbl.Location = new Point(20, 87);
                AddCardBtn.Visible = (HasChecking && HasSavings) ? false : true;
                CardObject.Visible = false;

                PercentBalance.Visible = false;
                BalanceLbl.Text = checking_balance ?? " ";
                PercentSavings.Visible = false;

                BalanceCardLbl.Text = HasChecking == true ? "Total Balance" : "No Checking Account";

            }
        }

 

        public Overview()
        {


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

        private void AddCardBtn_Click(object sender, EventArgs e)
        {
            Dashboard.DBPanel.Controls.Clear();
            Dashboard.DBPanel.Controls.Add(Dashboard.AddCard);

            //Dashboard.AddCard.BringToFront();

        }
    }
}
