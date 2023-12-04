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
            Date.CustomFormat = "yyyy-MM-dd";
            dashboard = form;
            AssociateAndRaiseViewEvents();
        }

        public event EventHandler AddNewCardEvent;
        public bool isSuccessful { get; set; }

        public Card Card { get; set; }

        private void AssociateAndRaiseViewEvents()
        {
            ConfirmBtn.Click += delegate
            {
                Card = new Card
                {
                    CardNumber = CardNumberTxtbox.Text,
                    Name = NameTxtbox.Text,
                    Email = EmailTxtbox.Text,
                    ExpiryDate = Date.Value,
                    PIN = PINTxtbox.Text
                };

                AddNewCardEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    dashboard.AddCard.Hide();
                    dashboard.Overview.Focus();

                }
                else
                {
                    MessageBox.Show("something went wrong");
                }
            };
        }

 
    }
}


