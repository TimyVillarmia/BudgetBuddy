using BudgetBuddy.Models;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace BudgetBuddy.Presenters
{
    internal class DoughnutChartPresenter
    {
        private readonly IAccountRepository _accountRepository;

        public static void Doughnut(GunaChart chart)
        {
            string[] typeofExpenses = { "Rent", "Foods", "Medical Bills", "Shopping" };

            chart.Legend.Position = LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            var dataset = new GunaDoughnutDataset();
            var r = new Random();

            for (int i = 0; i < typeofExpenses.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);

                dataset.DataPoints.Add(typeofExpenses[i], num);
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();



        }




    }
}
