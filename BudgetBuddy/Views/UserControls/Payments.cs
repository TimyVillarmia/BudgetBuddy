using BudgetBuddy._Repositories;
using BudgetBuddy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BudgetBuddy.Views.UserControls
{
    public partial class Payments : UserControl, IPaymentView
    {
        public Payments()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

        }

        public string PayToAccountNumber { get; set; }
        public string PayToAccountName { get; set; }
        public decimal MoneyTransferAmount { get; set; }


        public string Spotify = "347632688338096";

        public string Figma = "337941471904044";
        public string Youtube = "337941419909790";
        public string Netflix = "374283706337128";
        public users_bank_account Card { get; set; }

        public event EventHandler PayEvent;

        private void AssociateAndRaiseViewEvents()
        {
            PayBtn.Click += async delegate
            {
                try
                {
                    var respond = await MetrobankRepository.GetAccount(EmailTxtbox.Text);

                    if (PINTxtbox.Text == respond.PIN &&
                    CardNumberTxtbox.Text == respond.account_number &&
                    NameTxtBox.Text.ToLower() == respond.owner_name.ToLower() &&
                    EmailTxtbox.Text.ToLower() == respond.email.ToLower() &&
                    ExpiryDate.Value.ToString("yyyy-MM-dd") == respond.expiry_date.ToString("yyyy-MM-dd")
                    )
                    {

                        Card = new users_bank_account
                        {
                            account_number = respond.account_number,
                            account_type = respond.account_type,
                            owner_name = respond.owner_name,
                            expiry_date = respond.expiry_date,

                        };

                        DialogResult dialogResult = MessageBox.Show($"Are you sure to send {PayToAccountName} to {PayToAccountNumber}", "Quick Transfer", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            MoneyTransferAmount = Decimal.Parse(PriceTxtbox.Text);
                            PayEvent?.Invoke(this, EventArgs.Empty);
                            this.Focus();


                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            // do nothing
                        }


                        else
                        {
                            MessageBox.Show("something went wrong");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Make sure you completed the form correctly");

                    }






                }
                catch (Exception ex)
                {
                    throw ex;
                }
        



            };
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            ShopNameCombo.SelectedIndex = 0;
        }

        private void ShopNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] shop = { "Figma Pro Plan", "Youtube Premium", "Spotify Premium", "Netflix" };

            switch (ShopNameCombo.SelectedIndex)
            {
                case 0:
                    Picturebox.Image = Properties.Resources.Figma;
                    PayToAccountNumber = Figma;
                    PayToAccountName = "Figma";
                    NameShop.Text = shop[0];
                    break;
                case 1:
                    Picturebox.Image = Properties.Resources.Youtube;
                    PayToAccountNumber = Youtube;
                    PayToAccountName = "Youtube";

                    NameShop.Text = shop[1];
                    break;
                case 2:
                    Picturebox.Image = Properties.Resources.Spotify;
                    PayToAccountNumber = Spotify;
                    PayToAccountName = "Spotify";

                    NameShop.Text = shop[2];

                    break;
                case 3:
                    Picturebox.Image = Properties.Resources.Netflix;
                    PayToAccountNumber = Netflix;
                    PayToAccountName = "Netflix";

                    NameShop.Text = shop[3];
                    break;
            }

        }


    }
}
