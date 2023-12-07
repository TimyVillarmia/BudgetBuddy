using BudgetBuddy.Models;
using BudgetBuddy.Presenters.UserControls;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetBuddy.Repositories;
using BudgetBuddy.Presenters;
using BudgetBuddy._Repositories;

namespace BudgetBuddy
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
