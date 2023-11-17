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

        private void MainForm_Load(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            signin.Dock = DockStyle.Fill;

            Carousel carousel = new Carousel();
            carousel.Dock = DockStyle.Fill;

            // (usercontrol, col, row)
            MainFormPanel.Controls.Add(carousel, 0, 0);
            MainFormPanel.Controls.Add(signin, 1,0);


        }
    }
}
