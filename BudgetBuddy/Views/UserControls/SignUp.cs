using BudgetBuddy.Models;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Web.Configuration;

namespace BudgetBuddy.Presenters.UserControls
{
    public partial class SignUp : UserControl, ISignUpView
    {
        public MainForm MainForm;
        private bool _isSuccessful;

        public bool checkFirstname;
        public bool checkLastname;
        public bool checkEmail;
        public bool checkPassword;
        public bool checkConfirm;



        public SignUp(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
            AssociateAndRaiseViewEvents();

            EmailErrorLbl.Visible = false;
            PasswordErrorLbl.Visible = false;
            ConfirmErrorLbl.Visible = false;

        }

        public SignUp()
        {

        }

        private void AssociateAndRaiseViewEvents()
        {
            CreateAccountBtn.Click += delegate
            {

                if (checkFirstname && checkLastname && checkEmail && checkPassword && checkConfirm)
                {
                    CreateAccountEvent?.Invoke(this, EventArgs.Empty);

                    if (isSuccessful)
                    {
                        Session.SendOTP(EmailTxtBox.Text);
                        Session.CurrentUser = EmailTxtBox.Text;
                        MainForm.States = MainForm.states.SignUp;
                        MainForm.Confirmation.BringToFront();
                        MainForm.Confirmation.Focus();
                        FirstNameTxtBox.Clear();
                        LastNameTxtBox.Clear();
                        EmailTxtBox.Clear();
                        PasswordTxtBox.Clear();
                        RetypePassTxtBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("email is already registered");
                    }
                }
                else
                {
                    MessageBox.Show("Complete the form");

                }



            };
        }

  
   

        public string FirstName { get => FirstNameTxtBox.Text; set => FirstNameTxtBox.Text = value; }
        public string LastName { get => LastNameTxtBox.Text; set => LastNameTxtBox.Text = value; }
        public string Email { get => EmailTxtBox.Text; set => EmailTxtBox.Text = value; }
        public string Password { get => PasswordTxtBox.Text; set => PasswordTxtBox.Text = value; }
        public bool isSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
        public event EventHandler CreateAccountEvent;

        private void SignInLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.SignIn.BringToFront();

        }

        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTxtBox.TextLength < 8)
            {
                PasswordTxtBox.BorderColor = Color.Red;
                RetypePassTxtBox.BorderColor = Color.Red;
                PasswordErrorLbl.Visible = true;
                PasswordErrorLbl.Text = "Must be at least 8 characters long";
                checkPassword = false;
            }
            else
            {
                PasswordErrorLbl.Visible = false;
                PasswordTxtBox.BorderColor = Color.Green;
                RetypePassTxtBox.BorderColor = Color.Green;
                checkPassword = true;

            }
        }

        private void RetypePassTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTxtBox.Text != RetypePassTxtBox.Text)
            {
                RetypePassTxtBox.BorderColor = Color.Red;
                ConfirmErrorLbl.Visible = true;
                ConfirmErrorLbl.Text = "The password you entered does not match";
                checkConfirm = false;
            }
            else
            {
                ConfirmErrorLbl.Visible = false;
                RetypePassTxtBox.BorderColor = Color.Green;
                checkConfirm = true;

            }
        }

        private void PasswordState_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordState.Checked)
            {
                PasswordTxtBox.PasswordChar = '\0';
                RetypePassTxtBox.PasswordChar = '\0';

            }
            else
            {
                PasswordTxtBox.PasswordChar = '*';
                RetypePassTxtBox.PasswordChar = '*';
            }
        }

        private void FirstNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(FirstNameTxtBox.Text != string.Empty)
            {
                FirstNameTxtBox.BorderColor = Color.Green;
                checkFirstname = true;

            }
            else
            {
                FirstNameTxtBox.BorderColor = Color.Red;
                checkFirstname = false;

            }
        }

        private void LastNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTxtBox.Text != string.Empty)
            {
                LastNameTxtBox.BorderColor = Color.Green;
                checkLastname = true;

            }
            else
            {
                LastNameTxtBox.BorderColor = Color.Red;
                checkLastname = false;


            }
        }

        private void EmailTxtBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$";
            Regex regex = new Regex(pattern);
 
            if (EmailTxtBox.Text != string.Empty && regex.IsMatch(EmailTxtBox.Text))
            {
                EmailTxtBox.BorderColor = Color.Green;
                EmailErrorLbl.Visible = false;
                checkEmail = true;


            }
            else
            {
                EmailTxtBox.BorderColor = Color.Red;
                EmailErrorLbl.Visible = true;
                EmailErrorLbl.Text = "Please enter a valid email address, e.g. joe@mail.com";
                checkEmail = false;




            }
        }
    }
    
}
