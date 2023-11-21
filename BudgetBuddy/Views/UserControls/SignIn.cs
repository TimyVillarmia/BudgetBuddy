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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudgetBuddy.Presenters.UserControls
{
    public partial class SignIn : UserControl, ISignInView
    {
        public MainForm MainForm;
        private string _message;
        private bool _isSuccessful;

        public SignIn(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
            AssociateAndRaiseViewEvents();
            
        }


        public SignIn()
        {

        }


        private void AssociateAndRaiseViewEvents()
        {

            SignInBtn.Click += delegate
            {
                LoginAccountEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show($"{isSuccessful}");
                MessageBox.Show($"{test}");
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

        public string test
        {
            get; set;
        }

        public event EventHandler LoginAccountEvent;


        private void SignupLbl_Click(object sender, EventArgs e)
        {
            MainForm.SignUp.BringToFront();
        }

        //Singleton pattern (Open a single form instance)
   

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            //DataClasses1DataContext db = new DataClasses1DataContext();
            //var login = from acc in db.Accounts
            //            where acc.email == EmailTxtBox.Text &&
            //            acc.password == EmailTxtBox.Text
            //            select acc;

            //MessageBox.Show($"{login.Count()}");

        }
    }
}
