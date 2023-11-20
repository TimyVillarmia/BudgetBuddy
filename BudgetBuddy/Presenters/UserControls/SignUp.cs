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
    public partial class SignUp : UserControl
    {
        public MainForm MainForm;
        public SignUp(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void SignInLbl_Click(object sender, EventArgs e)
        {
            MainForm.SignIn.BringToFront();
        }


    }
}
