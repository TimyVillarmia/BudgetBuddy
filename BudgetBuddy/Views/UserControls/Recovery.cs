﻿using System;
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
using BudgetBuddy.Models;

namespace BudgetBuddy.Views.UserControls
{
    public partial class Recovery : UserControl, IRecoveryView
    {
        public MainForm MainForm;
        private bool _isSuccessful;

        public event EventHandler RecoverAccountEvent;

        public string Email 
        {
            get { return EmailTxtBox.Text; }
            set { EmailTxtBox.Text = value; }
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
                    Session.SendOTP(EmailTxtBox.Text);
                    MessageBox.Show(Session.OTP);
                    MainForm.Confirmation.BringToFront();
                    EmailTxtBox.Clear();
                    }
                else
                {
                    MessageBox.Show("Enter a valid Email");
                    EmailTxtBox.BorderColor = Color.Red;
                }
            };
        }

        // constructor overloading
        public Recovery()
        {

        }

        private void SignupLbl_Click(object sender, EventArgs e)
        {
        }

        private void EmailTxtBox_TextChanged(object sender, EventArgs e)
        {
            EmailTxtBox.BorderColor = Color.FromArgb(213, 218, 223);

        }

        private void SignupLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.SignUp.BringToFront();
        }
    }
}
