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


                if (newPasswordTxtBox.Text == RnewPasswordTxtBox.Text && newPasswordTxtBox.Text.Length >= 8)
                {
                    UpdatePasswordEvent?.Invoke(this, EventArgs.Empty);

                    if (isSuccessful)
                    {
                        MessageBox.Show("Password changed successfully");
                        MainForm.MainPanel.Controls.Clear();
                        MainForm.MainPanel.Controls.Add(MainForm.SignIn);

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
                    MessageBox.Show("Make sure you completed the form correctly");
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
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(MainForm.SignUp);
        }

        private void newPasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(newPasswordTxtBox.Text.Length >= 8)
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
                ErrorLbl.Text = "The password must be greater than or equal 8 characters";


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
