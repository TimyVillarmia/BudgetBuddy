using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BudgetBuddy.Views.UserControls
{
    public partial class Budgeting : UserControl
    {
        public Budgeting()
        {
            InitializeComponent();
        }

        private void Budgeting_Load(object sender, EventArgs e)
        {
            LoadDoughnut(DoughnutChart);
            LoadLineChart(LineChart);
        }
        private void LoadDoughnut(GunaChart doughnut)
        {
            string[] categories = { "Food", "Rent", "Bills", "Subscription" };

            //Chart configuration
            doughnut.Title.Text = "Spending Acitivities";
            doughnut.Legend.Position = LegendPosition.Right;
            doughnut.XAxes.Display = false;
            doughnut.YAxes.Display = false;


            var r = new Random();
            int num = r.Next(10, 100);

            var dataset = new GunaDoughnutDataset();

            dataset.DataPoints.Add(categories[0], num);
            dataset.DataPoints.Add(categories[1], num);
            dataset.DataPoints.Add(categories[2], num);
            dataset.DataPoints.Add(categories[3], num);


            //Create a new dataset 


            //Add a new dataset to a chart.Datasets
            doughnut.Datasets.Add(dataset);

            //An update was made to re-render the chart
            doughnut.Update();
        }

        private void LoadLineChart(GunaChart linechart)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            //Chart configuration 
            linechart.YAxes.GridLines.Display = false;

            //Create a new dataset 
            var dataset = new GunaLineDataset();
            dataset.PointRadius = 10;
            dataset.PointStyle = PointStyle.Circle;
            var r = new Random();
            for (int i = 0; i < months.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);

                dataset.DataPoints.Add(months[i], num);
            }

            //Add a new dataset to a chart.Datasets
            linechart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            linechart.Update();
        }
    }
}
