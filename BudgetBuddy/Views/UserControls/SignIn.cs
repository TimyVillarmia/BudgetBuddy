using BudgetBuddy.Models;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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



        // events
        public event EventHandler LoginAccountEvent;


        // methods
        private void SignupLbl_Click(object sender, EventArgs e)
        {
            
            MainForm.signUp.BringToFront();
        }

        private void RecoveryLbl_Click(object sender, EventArgs e)
        {
            MainForm.recovery.BringToFront();
        }
    }
}
