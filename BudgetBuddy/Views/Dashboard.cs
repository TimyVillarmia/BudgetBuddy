using BudgetBuddy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetBuddy.Views;
using BudgetBuddy.Views.UserControls;

namespace BudgetBuddy.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
 
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Overview overview = new Overview()
            {
                Dock = DockStyle.Fill
            };
             
            DashboardPanel.Controls.Add(overview);
        }
    }
}
