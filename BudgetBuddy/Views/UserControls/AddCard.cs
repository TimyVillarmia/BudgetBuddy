using BudgetBuddy._Repositories;
using BudgetBuddy.Models;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BudgetBuddy._Repositories.Encryption;

namespace BudgetBuddy.Views.UserControls
{



    public partial class AddCard : UserControl, IAddCardView
    {
        private readonly Dashboard1 dashboard;

        public AddCard(Dashboard1 form)
        {
            InitializeComponent();
            ExpiryDate.CustomFormat = "yyyy-MM-dd";
            dashboard = form;
            AssociateAndRaiseViewEvents();
        }

        public event EventHandler AddNewCardEvent;
        public bool isSuccessful { get; set; }

        public users_bank_account new_account { get; set; }

        private void AssociateAndRaiseViewEvents()
        {
            this.Load += delegate
            {
                AccountTypeCombo.SelectedIndex = 0;
            };

            ConfirmBtn.Click += async delegate
            {
                if(PINTxtbox.Text != string.Empty &&
                CardNumberTxtbox.Text != string.Empty &&
                NameTxtbox.Text != string.Empty &&
                EmailTxtbox.Text != string.Empty &&
                ExpiryDate.Value.ToString("yyyy-MM-dd") != string.Empty &&
                AccountTypeCombo.SelectedItem.ToString() != string.Empty
                )
                {
                    try
                    {
                        var respond = await MetrobankRepository.GetAccountFromJSONServer(EmailTxtbox.Text, CardNumberTxtbox.Text);

                        if (PINTxtbox.Text == respond.PIN &&
                        CardNumberTxtbox.Text == respond.account_number &&
                        NameTxtbox.Text.ToLower() == respond.owner_name.ToLower() &&
                        EmailTxtbox.Text.ToLower() == respond.email.ToLower() &&
                        ExpiryDate.Value.ToString("yyyy-MM-dd") == respond.expiry_date.ToString("yyyy-MM-dd") &&
                        AccountTypeCombo.SelectedItem.ToString().ToLower() == respond.account_type
                        )
                        {

                            new_account = new users_bank_account
                            {
                                external_id = respond.external_id,
                                account_type = respond.account_type

                            };

                            AddNewCardEvent?.Invoke(this, EventArgs.Empty);

                            if (isSuccessful)
                            {
                                dashboard.DBPanel.Controls.Clear();
                                dashboard.DBPanel.Controls.Add(dashboard.Overview);

                                //dashboard.AddCard.Hide();
                                //dashboard.Overview.BringToFront();
                                //dashboard.Overview.Focus();


                            }
                            else
                            {
                                MessageBox.Show($"The {AccountTypeCombo.SelectedItem.ToString()} Account is already added");
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
                }
                else
                {
                    MessageBox.Show("Make sure you completed the form correctly");

                }


            };



            CancelBtn.Click += delegate
            {
                dashboard.DBPanel.Controls.Clear();
                dashboard.DBPanel.Controls.Add(dashboard.Overview);
            };
        }

 
    }
}


