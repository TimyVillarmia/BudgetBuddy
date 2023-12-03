using BudgetBuddy.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Views
{
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void Dashboard1_Load(object sender, EventArgs e)
        {
            Overview overview = new Overview()
            {
                Dock = DockStyle.Fill
            };

            DashboardPanel.Controls.Add(overview);
        }
    }
}
