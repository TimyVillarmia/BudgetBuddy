using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Views.UserControls
{
    public partial class Recovery2 : UserControl, IRecovery2View
    {
        public MainForm MainForm;
        private bool _isSuccessful;
        public event EventHandler UpdatePasswordEvent;

        public Recovery2(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            ErrorLbl.Visible = false;
            Error1Lbl.Visible = false;
            AssociateAndRaiseViewEvents();
            
        }

        private void AssociateAndRaiseViewEvents()
        {
            RecoverBtn.Click += delegate 
            {


                if (newPasswordTxtBox.Text == RnewPasswordTxtBox.Text)
                {
                    UpdatePasswordEvent?.Invoke(this, EventArgs.Empty);

                    if (isSuccessful)
                    {
                        MainForm.SignIn.BringToFront();
                        MainForm.SignIn.Focus();
                        newPasswordTxtBox.Clear();
                        RnewPasswordTxtBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }


                }
                else
                {
                    MessageBox.Show("Password is not Matched");
                }


            };
        }

        public string Password
        {
            get { return RnewPasswordTxtBox.Text; }
            set { RnewPasswordTxtBox.Text = value; }
        }
        public bool isSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }


        private void SignupLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.SignUp.BringToFront();
        }

        private void newPasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(newPasswordTxtBox.Text == RnewPasswordTxtBox.Text)
            {
                newPasswordTxtBox.BorderColor = Color.Green;
                RnewPasswordTxtBox.BorderColor = Color.Green;
                ErrorLbl.Visible = false;
                Error1Lbl.Visible = false;

            }
            else
            {
                newPasswordTxtBox.BorderColor = Color.Red;
                RnewPasswordTxtBox.BorderColor = Color.Red;
                ErrorLbl.Visible = true;
                Error1Lbl.Visible = true;
                ErrorLbl.Text = "The password you entered does not match";
                Error1Lbl.Text = "The password you entered does not match";

            }
        }

        private void RnewPasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (newPasswordTxtBox.Text == RnewPasswordTxtBox.Text)
            {
                newPasswordTxtBox.BorderColor = Color.Green;
                RnewPasswordTxtBox.BorderColor = Color.Green;
                ErrorLbl.Visible = false;
                Error1Lbl.Visible = false;
            }
            else
            {
                newPasswordTxtBox.BorderColor = Color.Red;
                RnewPasswordTxtBox.BorderColor = Color.Red;
                ErrorLbl.Visible = true;
                Error1Lbl.Visible = true;
                ErrorLbl.Text = "The password you entered does not match";
                Error1Lbl.Text = "The password you entered does not match";
            }
        }

        private void PasswordState_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordState.Checked)
            {
                newPasswordTxtBox.PasswordChar = '\0';
                RnewPasswordTxtBox.PasswordChar = '\0';
                    
            }
            else
            {
                newPasswordTxtBox.PasswordChar = '*';
                RnewPasswordTxtBox.PasswordChar = '*';
            }
        }
    }
}
