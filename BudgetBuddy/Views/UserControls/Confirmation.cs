using BudgetBuddy.Models;
using System;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
            AssociateAndRaiseViewEvents();

        }



        private void AssociateAndRaiseViewEvents()
        {
            ResendLbl.Click += async delegate
            {
                await Session.SendOTP(Session.CurrentUser);

            };

            this.Load += async delegate
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
            if (OTP == Models.Session.OTP || true)
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

                            MainForm.MainPanel.Controls.Clear();
                            MainForm.MainPanel.Controls.Add(MainForm.SignIn);

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
                            MainForm.MainPanel.Controls.Clear();
                            MainForm.MainPanel.Controls.Add(MainForm.Recovery2);

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
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(MainForm.SignIn);
            MainForm.SignIn.isSuccessful = false;
        }


 

        private void Confirmation_Enter(object sender, EventArgs e)
        {
            emailPlaceHolder.Text = Session.CurrentUser;
        }
    }
}
