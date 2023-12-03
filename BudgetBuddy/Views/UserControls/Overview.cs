using BudgetBuddy.Views.Charts;
using System;
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
    public partial class Overview : UserControl, IOverviewView
    {
        public Dashboard1 MainForm;

        public event EventHandler LoadOverviewData;
        public event EventHandler AddNewCardEvent;
        public event EventHandler SendEvent;
        public event EventHandler RequestEvent;

        public Overview(Dashboard1 form)
        {
            InitializeComponent();
            MainForm = form;

        }

        public Overview()
        {

        }



        private void Overview_Load(object sender, EventArgs e)
        {

            DoughnutChart doughnutChart = new DoughnutChart();

            ChartPanel.Controls.Add(doughnutChart);
        }
    }
}
