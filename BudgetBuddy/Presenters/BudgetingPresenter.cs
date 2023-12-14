using BudgetBuddy.Models;
using BudgetBuddy.Views;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BudgetBuddy.Presenters
{
    public class BudgetingPresenter
    {
        // fields Dependency Injection
        private readonly IAccountRepository _accountRepository;
        private readonly IBudgetingView _view;

        private IEnumerable<TransactionModel> transactionList;




        // constructor
        public BudgetingPresenter(IAccountRepository accountRepository, IBudgetingView view)
        {



            _accountRepository = accountRepository;
            _view = view;
    

            LoadDoughnutChart();
            LoadLineChart();


        }

        private void LoadLineChart()
        {
            transactionList = _accountRepository.GetTransactionsList();

            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };



            //Chart configuration
            _view.Line.YAxes.GridLines.Display = false;




            var dataset = new GunaLineDataset();
            dataset.PointRadius = 10;
            dataset.PointStyle = PointStyle.Circle;


            for (int i = 0; i < months.Length; i++)
            {


                var allSpendingsPerMonth = transactionList
                                        .Where(date => date.date.Month == i+1)
                                        .Select(amount => amount.amount)
                                        .Sum();

                dataset.DataPoints.Add(months[i], Convert.ToDouble(allSpendingsPerMonth));
            }








            //Create a new dataset 

            //Add a new dataset to a chart.Datasets
            _view.Line.Datasets.Add(dataset);



            //An update was made to re-render the chart
            _view.Line.Update();
        }

        public void LoadDoughnutChart()
        {
            transactionList = _accountRepository.GetTransactionsList();




            //Chart configuration
            _view.Doughnut.Title.Text = "Spending Acitivities";
            _view.Doughnut.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            _view.Doughnut.XAxes.Display = false;
            _view.Doughnut.YAxes.Display = false;




            var dataset = new GunaPieDataset();



            var subscriptionDataSet = transactionList
                                    .Where(type => type.TransactionName == "Subscription")
                                    .Select(amount => amount.amount)
                                    .Sum();

            var billsDataSet = transactionList
                               .Where(type => type.TransactionName == "Bills")
                               .Select(amount => amount.amount)
                               .Sum();

            var foodDataSet = transactionList
                              .Where(type => type.TransactionName == "Food")
                              .Select(amount => amount.amount)
                              .Sum();

            var moneyTransferDataSet = transactionList
                                       .Where(type => type.TransactionName == "Send" || type.TransactionName == "Receive")
                                       .Select(amount => amount.amount)
                                       .Sum();





            dataset.DataPoints.Add("Subscription", Convert.ToDouble(subscriptionDataSet));

            dataset.DataPoints.Add("Bills", Convert.ToDouble(billsDataSet));

            dataset.DataPoints.Add("Food", Convert.ToDouble(foodDataSet));

            dataset.DataPoints.Add("MoneyTransfer", Convert.ToDouble(moneyTransferDataSet));


            //Create a new dataset 

            //Add a new dataset to a chart.Datasets
            _view.Doughnut.Datasets.Add(dataset);



            //An update was made to re-render the chart
            _view.Doughnut.Update();
        }

    }
}
