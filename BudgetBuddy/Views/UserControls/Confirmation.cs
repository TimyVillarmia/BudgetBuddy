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

namespace BudgetBuddy.Views.UserControls
{
    public partial class Confirmation : UserControl
    {
        public Confirmation()
        {
            InitializeComponent();
            placeholder.Text = Session.CurrentUser;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            var OTP = firstDigitOTP.Text + secondDigitOTP.Text + thirdDigitOTP.Text + fourthDigitOTP.Text + fifthDigitOTP.Text + sixthDigitOTP.Text;

            if(OTP == Session.OTP)
            {
                Session.isSuccesful = true;

                if (Session.isSuccesful)
                {
                    ParentForm.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                    ParentForm.Close();
                }
            }
            else
            {
                Session.isSuccesful = false;
                MessageBox.Show($"{Session.isSuccesful}");

            }
        }
    }
}
