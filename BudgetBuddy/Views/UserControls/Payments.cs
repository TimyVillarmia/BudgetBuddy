using BudgetBuddy._Repositories;
using BudgetBuddy.Models;
using BudgetBuddy.Repositories;
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

        public bool hasAccount { get; set; }
        public string Email { get; set; }
       public string Sender_name { get; set; }
        public string Sender_number { get; set; }


        public string PayToAccountNumber { get; set; }
        public string PayToAccountName { get; set; }
        public decimal MoneyTransferAmount { get; set; }



        public users_bank_account Card { get; set; }

        public event EventHandler PayEvent;
        public event EventHandler LoadEvent;

        private void AssociateAndRaiseViewEvents()
        {
            PayBtn.Click += async delegate
            {
                try
                {

                    var respond = await MetrobankRepository.GetAccountFromJSONServer(EmailTxtbox.Text, CardNumberTxtbox.Text);


                    if (PINTxtbox.Text == respond.PIN &&
                    CardNumberTxtbox.Text == respond.account_number &&
                    NameTxtBox.Text.ToLower() == respond.owner_name.ToLower() &&
                    EmailTxtbox.Text.ToLower() == respond.email.ToLower() &&
                    ExpiryDate.Value.ToString("yyyy-MM-dd") == respond.expiry_date.ToString("yyyy-MM-dd") &&
                    TypeComboBox.SelectedItem.ToString() != string.Empty &&
                    ShopNameCombo.SelectedItem.ToString() != string.Empty &&
                    PriceTxtbox.Text != string.Empty &&
                    BillingComboBox.SelectedItem.ToString() != string.Empty
                    )
                    {

       
                        DialogResult dialogResult = MessageBox.Show($"Are you sure to send {PayToAccountName} to {PayToAccountNumber}", "Quick Transfer", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            var vendor = await MetrobankRepository.PaytoVendor(PayToAccountName);
                            PayToAccountNumber = vendor.account_number;
                            MoneyTransferAmount = Decimal.Parse(PriceTxtbox.Text);

                            Sender_name = respond.owner_name;
                            Sender_number = respond.account_number;

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


            this.Load += delegate
            {
                TypeComboBox.SelectedIndex = 0;
                ShopNameCombo.SelectedIndex = 0;
                LoadEvent?.Invoke(this, EventArgs.Empty);

                if (hasAccount)
                {
                    EmailTxtbox.Text = Email;
                    CardNumberTxtbox.Text = Sender_number;
                    NameTxtBox.Text = Sender_name;
                }
                else
                {
                    EmailTxtbox.Text = "";
                    CardNumberTxtbox.Text = "";
                    NameTxtBox.Text = "";
                }

            };

            TypeComboBox.SelectedIndexChanged += delegate
            {

                List<string> subscriptionItems = new List<string> { "Youtube Premium", "Spotify Premium", "Netflix" };
                List<string> billsItems = new List<string> { "Visayan Electric", "MCWD", "Converge ICT"};
                List<string> foodItems = new List<string> { "McDonalds", "Jollibee", "KFC"};



                switch (TypeComboBox.SelectedIndex)
                {
                    case 0:
                        ShopNameCombo.Items.Clear();
                        subscriptionItems.ForEach(item => ShopNameCombo.Items.Add(item));
                        break;
                    case 1:
                        ShopNameCombo.Items.Clear();
                        billsItems.ForEach(item => ShopNameCombo.Items.Add(item));
                        break;
                    case 2:
                        ShopNameCombo.Items.Clear();
                        foodItems.ForEach(item => ShopNameCombo.Items.Add(item));
                        break;
                }




            };


            ShopNameCombo.SelectedIndexChanged += delegate
            {
      

                // Create a new dictionary of strings, with string keys.
                //
                Dictionary<string, Bitmap> pictures = new Dictionary<string, Bitmap>
                {
                    // Add some elements to the dictionary. There are no
                    // duplicate keys, but some of the values are duplicates.
                    { "Youtube Premium", Properties.Resources.Youtube },
                    { "Spotify Premium", Properties.Resources.Spotify },
                    { "Netflix", Properties.Resources.Netflix },
                    { "Visayan Electric", Properties.Resources.VECO },
                    { "MCWD", Properties.Resources.MCWD },
                    { "Converge ICT", Properties.Resources.Converge },
                    { "McDonalds", Properties.Resources.McDonalds },
                    { "Jollibee", Properties.Resources.Jollibee },
                    { "KFC", Properties.Resources.KFC }
                };
                
                Picturebox.Image = pictures[ShopNameCombo.SelectedItem.ToString()];
                PayToAccountName = ShopNameCombo.SelectedItem.ToString();
                NameShop.Text = ShopNameCombo.SelectedItem.ToString();
            };
        }





    }
}
