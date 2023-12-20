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
            this.Load += delegate
            {
                isSuccessful = false;
            };

            // subscribing events using lambda expression and delagate
            // subscibe SignInBtn.Click event to delagate LoginAccountEvent
            SignInBtn.Click += delegate
            {
                // invoking the event
                LoginAccountEvent?.Invoke(this, EventArgs.Empty);

                //after the LoginAccountEvent += LoginAccount from the SignInPresenter
                if (isSuccessful)
                {
                    Session.CurrentUser = EmailTxtBox.Text.Trim().ToLower();
                    MainForm.States = MainForm.states.Login;

                    MainForm.MainPanel.Controls.Clear();
                    MainForm.MainPanel.Controls.Add(MainForm.Confirmation);

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
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(MainForm.Recovery1);
        }

        private void EmailTxtBox_TextChanged(object sender, EventArgs e)
        {
            EmailTxtBox.BorderColor = Color.FromArgb(213, 218, 223);
        }

        private void SignupLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(MainForm.SignUp);
        }

        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTxtBox.BorderColor = Color.FromArgb(213, 218, 223);

        }

        private void PasswordState_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordState.Checked)
            {
                PasswordTxtBox.PasswordChar = '\0';

            }
            else
            {
                PasswordTxtBox.PasswordChar = '*';

            }

        }

        private void PasswordTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignInBtn.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
