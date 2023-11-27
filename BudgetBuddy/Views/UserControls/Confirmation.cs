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
        public MainForm MainForm;

        public Confirmation(MainForm form)
        {
            InitializeComponent();
            placeholder.Text = Session.CurrentUser;
            MainForm = form;

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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            MainForm.SignIn.BringToFront();
        }


        private void ResendLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.SendOTP(Session.CurrentUser);

        }
    }
}
