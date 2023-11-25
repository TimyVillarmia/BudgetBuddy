﻿using System;
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
    public partial class Recovery : UserControl
    {
        public MainForm MainForm;

        public Recovery(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
        }

        public Recovery()
        {

        }

        private void SignupLbl_Click(object sender, EventArgs e)
        {
            MainForm.signUp.BringToFront();
        }
    }
}
