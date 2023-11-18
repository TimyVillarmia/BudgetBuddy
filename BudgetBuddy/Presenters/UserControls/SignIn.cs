﻿using System;
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
    public partial class SignIn : UserControl
    {
        public MainForm MainForm;

        public SignIn(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void SignupLbl_Click(object sender, EventArgs e)
        {
            MainForm.SignUp.BringToFront();
        }
    }
}
