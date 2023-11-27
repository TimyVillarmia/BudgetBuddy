using BudgetBuddy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            MainForm = form;

        }

        public Confirmation()
        {

        }



        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            var OTP = firstDigitOTP.Text + secondDigitOTP.Text + thirdDigitOTP.Text + fourthDigitOTP.Text + fifthDigitOTP.Text + sixthDigitOTP.Text;
            emailPlaceHolder.Text = Session.CurrentUser;
            if (OTP == Session.OTP)
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

        private void Confirmation_Enter(object sender, EventArgs e)
        {
            emailPlaceHolder.Text = Session.CurrentUser;
        }
    }
}
