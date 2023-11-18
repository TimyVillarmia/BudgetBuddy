using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetBuddy.Presenters.UserControls;

namespace BudgetBuddy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public SignIn SignIn { get; set; }
        public SignUp SignUp { get; set; }
        private void MainForm_Load(object sender, EventArgs e)
        {
            SignIn = new SignIn(this);
            SignIn.Dock = DockStyle.Fill;

            SignUp = new SignUp(this);
            SignUp.Dock = DockStyle.Fill;

            Carousel carousel = new Carousel();
            carousel.Dock = DockStyle.Fill;

            
            MainFormLeftPanel.Controls.Add(carousel);
            MainFormRightPanel.Controls.Add(SignIn);
            MainFormRightPanel.Controls.Add(SignUp);


        }
    }
}
