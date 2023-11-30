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
            if (OTP == Models.Session.OTP)
            {
                Models.Session.isSuccesful = true;

                if (Models.Session.isSuccesful)
                {
                    // acts as a routing
                    // after otp is confirm
                    //route to the next state/user controls
                    switch (MainForm.States)
                    {

                        case MainForm.states.Login:
                            // Login -> Confirmation -> Dashboard
                            ParentForm.Hide();
                            Dashboard dashboard = new Dashboard();
                            dashboard.ShowDialog();
                            ParentForm.Close();
                            break;

                        case MainForm.states.SignUp:
                            // SignUp -> Confirmation -> SignIn
                            MainForm.SignIn.BringToFront();
                            MainForm.SignIn.Focus();
                            break;

                        case MainForm.states.Recovery:
                            // Recovery1(Email) -> Confirmation -> Recovery2(Update Password)
                            MainForm.Recovery2.BringToFront();
                            MainForm.Recovery2.Focus();
                            break;
                    }


                }
            }
            else
            {
                Models.Session.isSuccesful = false;
                MessageBox.Show("Incorrect OTP");


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
