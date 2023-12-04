using BudgetBuddy.Models;
using System;
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
            ResendLbl.Click += AssociateAndRaiseViewEvents;

        }

        private void AssociateAndRaiseViewEvents(object sender, EventArgs e)
        {
            ResendLbl.Click += async delegate
            {
                await Session.SendOTP(Session.CurrentUser);

            };
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
                            Dashboard1 dashboard = new Dashboard1();
                            dashboard.ShowDialog();
                            ParentForm.Close();
                            break;

                        case MainForm.states.SignUp:
                            // SignUp -> Confirmation -> SignIn
                            firstDigitOTP.Clear();
                            secondDigitOTP.Clear();
                            thirdDigitOTP.Clear();
                            fourthDigitOTP.Clear();
                            fifthDigitOTP.Clear();
                            sixthDigitOTP.Clear();
                            MainForm.SignIn.BringToFront();
                            MainForm.SignIn.Focus();
                            break;

                        case MainForm.states.Recovery:
                            // Recovery1(Email) -> Confirmation -> Recovery2(Update Password)
                            firstDigitOTP.Clear();
                            secondDigitOTP.Clear();
                            thirdDigitOTP.Clear();
                            fourthDigitOTP.Clear();
                            fifthDigitOTP.Clear();
                            sixthDigitOTP.Clear();
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


 

        private void Confirmation_Enter(object sender, EventArgs e)
        {
            emailPlaceHolder.Text = Session.CurrentUser;
        }
    }
}
