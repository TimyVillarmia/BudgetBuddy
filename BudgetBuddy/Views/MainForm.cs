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


        public MainForm()
        {
            InitializeComponent();
            

        }



        public SignIn SignIn { get; set; }
        public SignUp SignUp { get; set; }



        private void MainForm_Load(object sender, EventArgs e)
        {
            // Declare a new db instance 
            DataClasses1DataContext db = new DataClasses1DataContext();
            IAccountRepository accountRepository = new AccountRepository(db);

            // Declare a new SignIn instance 
            SignIn = new SignIn(this);
            SignIn.Dock = DockStyle.Fill; // style

            // Declare a signInView interface instance.
            ISignInView signInView = SignIn;

            //inject accountRepository, signInView
            new SignInPresenter(accountRepository, signInView);



            // create a new SignIn instance 
            SignUp = new SignUp(this);
            SignUp.Dock = DockStyle.Fill;

            Carousel carousel = new Carousel();
            carousel.Dock = DockStyle.Fill;


            MainFormLeftPanel.Controls.Add(carousel);
            MainFormRightPanel.Controls.Add(SignIn);
            MainFormRightPanel.Controls.Add(SignUp);


        }
    }
}
