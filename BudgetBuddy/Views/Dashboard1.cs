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
using BudgetBuddy.Presenters;
using BudgetBuddy.Models;
using BudgetBuddy.Repositories;

namespace BudgetBuddy.Views
{
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        public Overview Overview { get; set; }

        private void Dashboard1_Load(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            IAccountRepository accountRepository = new AccountRepository(db);

            Overview = new Overview(this)
            {
                Dock = DockStyle.Fill
            };

            IOverviewView overview = Overview;

            new OverviewPresenter(accountRepository, overview);

            DashboardPanel.Controls.Add(Overview);
        }
    }
}
