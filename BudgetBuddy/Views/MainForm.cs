using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetBuddy.Models;
using BudgetBuddy.Presenters;
using BudgetBuddy.Presenters.UserControls;
using BudgetBuddy.Repositories;
using BudgetBuddy.Views;

namespace BudgetBuddy
{
    public partial class MainForm : Form
    {

        // constructor
        public MainForm()
        {
            InitializeComponent();
            

        }


        // Singleton pattern (only 1 instance of each user control throughout the system)
        public SignIn SignIn { get; set; }
        public SignUp SignUp { get; set; }



        private void MainForm_Load(object sender, EventArgs e)
        {
            // Declare a new db instance 
            DataClasses1DataContext db = new DataClasses1DataContext();
            IAccountRepository accountRepository = new AccountRepository(db);

            // Declare a new SignIn instance 
            SignIn = new SignIn(this)
            {
                Dock = DockStyle.Fill // style
            };
            SignUp = new SignUp(this)
            {
                Dock = DockStyle.Fill // style
            };
            Pagination pagination = new Pagination
            {
                Dock = DockStyle.Fill  // style
            };

            // Declare a signInView interface instance.
            ISignInView signInView = SignIn;

            //Dependency Injection
            new SignInPresenter(accountRepository, signInView);



            // inserting usercontrols in the panel
            MainFormLeftPanel.Controls.Add(pagination); //left
            MainFormRightPanel.Controls.Add(SignIn); //right
            MainFormRightPanel.Controls.Add(SignUp);


        }
    }
}
