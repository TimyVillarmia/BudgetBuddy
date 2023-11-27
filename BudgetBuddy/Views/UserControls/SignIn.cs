using BudgetBuddy.Models;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BudgetBuddy.Presenters.UserControls
{
    public partial class SignIn : UserControl, ISignInView
    {
        // fields
        public MainForm MainForm;
        private bool _isSuccessful;

        // events
        public event EventHandler LoginAccountEvent;

        // constructor
        public SignIn(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
            AssociateAndRaiseViewEvents();

            
        }

        // constructor overloading
        public SignIn()
        {

        }


        private void AssociateAndRaiseViewEvents()
        {
            // subscribing events using lambda expression and delagate
            // subscibe SignInBtn.Click event to delagate LoginAccountEvent
            SignInBtn.Click += delegate
            {
                // invoking the event
                LoginAccountEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    
                    Session.SendOTP(EmailTxtBox.Text);
                    Session.CurrentUser = EmailTxtBox.Text;
                    MainForm.Confirmation.BringToFront();
                    MainForm.Confirmation.Focus();
                    EmailTxtBox.Clear();
                    PasswordTxtBox.Clear();




                }
                else
                {
                    MessageBox.Show("Incorrect Email or Password");
                    EmailTxtBox.BorderColor = Color.Red;
                    PasswordTxtBox.BorderColor = Color.Red;

                }
            };

        }

        // implement interface
        public string Email 
        { 
            get { return EmailTxtBox.Text; }
            set { EmailTxtBox.Text = value; }
        }
        public string Password
        {
            get { return PasswordTxtBox.Text; }
            set { PasswordTxtBox.Text = value; }
        }
        public bool isSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value;  }
        }






        // methods

        private void RecoveryLbl_Click(object sender, EventArgs e)
        {
            MainForm.Recovery.BringToFront();
        }

        private void EmailTxtBox_TextChanged(object sender, EventArgs e)
        {
            EmailTxtBox.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void SignupLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.SignUp.BringToFront();

        }

        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTxtBox.BorderColor = Color.FromArgb(213, 218, 223);

        }
    }
}
