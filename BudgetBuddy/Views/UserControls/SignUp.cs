using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Presenters.UserControls
{
    public partial class SignUp : UserControl, ISignUpView
    {
        public MainForm MainForm;
        public SignUp(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
        }

        public string FirstName { get => FirstNameTxtBox.Text; set => FirstNameTxtBox.Text = value; }
        public string LastName { get => LastNameTxtBox.Text; set => LastNameTxtBox.Text = value; }
        public string Email { get => EmailTxtBox.Text; set => EmailTxtBox.Text = value; }
        public string Password { get => PasswordTxtBox.Text; set => PasswordTxtBox.Text = value; }

        public event EventHandler CreateAccount;

        private void SignInLbl_Click(object sender, EventArgs e)
        {
            MainForm.SignIn.BringToFront();
        }


    }
}
