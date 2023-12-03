using BudgetBuddy.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Views.Charts
{
    public partial class DoughnutChart : UserControl
    {
        public DoughnutChart()
        {
            InitializeComponent();
        }

        private void DoughnutChart_Load(object sender, EventArgs e)
        {
            Presenters.DoughnutChart.Doughnut(gunaChart1);
        }
    }
}
