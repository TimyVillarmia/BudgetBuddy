﻿using BudgetBuddy._Repositories;
using BudgetBuddy.Models;
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

        public users_bank_account Card { get; set; }

        private void AssociateAndRaiseViewEvents()
        {
            ConfirmBtn.Click += async delegate
            {
                try
                {
                    var respond = await MetrobankRepository.GetAccount(EmailTxtbox.Text);

                    if (PINTxtbox.Text == respond.PIN &&
                    CardNumberTxtbox.Text == respond.account_number &&
                    NameTxtbox.Text.ToLower() == respond.owner_name.ToLower() &&
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

                        AddNewCardEvent?.Invoke(this, EventArgs.Empty);

                        if (isSuccessful)
                        {
                            dashboard.AddCard.Hide();
                            dashboard.Overview.BringToFront();
                            dashboard.Overview.Focus();

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
                catch(Exception ex)
                {
                    throw ex;
                }
            };
        }

 
    }
}


