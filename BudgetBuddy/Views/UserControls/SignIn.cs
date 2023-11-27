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
        private readonly string _message;
        private bool _isSuccessful;
        private string _currentUser;

        // events
        public event EventHandler LoginAccountEvent;

        // constructor
        public SignIn(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
            AssociateAndRaiseViewEvents();
            emailErrorLbl.Visible = false;
            passErrorLbl.Visible = false;
            
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
                    ParentForm.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                    ParentForm.Close();

                }
                else
                {
                    MessageBox.Show("Error!");
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
        public string CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }






        // methods
        private void SignupLbl_Click(object sender, EventArgs e)
        {
            
            MainForm.SignUp.BringToFront();
        }

        private void RecoveryLbl_Click(object sender, EventArgs e)
        {
            MainForm.Recovery.BringToFront();
        }

    }
}
