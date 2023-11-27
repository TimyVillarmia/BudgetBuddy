using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;  
using MailKit.Net.Smtp;

namespace BudgetBuddy.Views.UserControls
{
    public partial class Recovery : UserControl, IRecoveryView
    {
        public MainForm MainForm;
        private protected string _OTP;
        private bool _isSuccessful;

        public event EventHandler RecoverAccountEvent;

        public string Email 
        {
            get { return EmailTxtBox.Text; }
            set { EmailTxtBox.Text = value; }
        }
        public string OTP
        {
            get { return _OTP; }
            set { _OTP = value; }
        }

        public bool isSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }

        // constructor
        public Recovery(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
            AssociateAndRaiseViewEvents();
            errorLbl.Visible = false;

        }

        private void AssociateAndRaiseViewEvents()
        {
            // subscribing events using lambda expression and delagate
            // subscibe OTPBtn.Click event to delagate RecoverAccountEvent
            OTPBtn.Click += delegate
            {
                // invoking the event
                RecoverAccountEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    _OTP = GenerateOTP();
                    MessageBox.Show(_OTP);
                    MainForm.Confirmation.BringToFront();
                }
                else
                {
                    errorLbl.Visible = true;
                    EmailTxtBox.BorderColor = Color.Red;
                    errorLbl.Text = "Email is not registred";
                }
            };
        }

        // constructor overloading
        public Recovery()
        {

        }

        private void SignupLbl_Click(object sender, EventArgs e)
        {
            MainForm.SignUp.BringToFront();
        }



        //method for generating OTP
        public string GenerateOTP()
        {
            string otp_char = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            _OTP = "";
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {

                var random_char = otp_char[rnd.Next(1, otp_char.Length)];
                _OTP += random_char;

            }
            return _OTP;
        }
    }
}
