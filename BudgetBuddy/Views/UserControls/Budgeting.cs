using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BudgetBuddy.Views.UserControls
{
    public partial class Budgeting : UserControl, IBudgetingView
    {
        public Budgeting()
        {
            InitializeComponent();
        }

        public GunaChart Doughnut
        {
            get { return DoughnutChart; }
            set { DoughnutChart = value; }
        }

        public GunaChart Line
        {
            get { return LineChart; }
            set { LineChart = value; }
        }
        private void Budgeting_Load(object sender, EventArgs e)
        {
        }
   

    }
}
