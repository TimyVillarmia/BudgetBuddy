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
using BudgetBuddy.Views.UserControls;

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
        public Recovery1 Recovery1 { get; set; }
        public Recovery2 Recovery2 { get; set; }
        public Confirmation Confirmation { get; set; }
        public bool fromRecovery { get; set; } = false;


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
            Recovery1 = new Recovery1(this)
            {
                Dock = DockStyle.Fill
            };
            Recovery2 = new Recovery2(this)
            {
                Dock = DockStyle.Fill
            };

            Pagination pagination= new Pagination()
            {
                Dock = DockStyle.Fill  // style
            };
            Confirmation  = new Confirmation(this)
            {
                Dock = DockStyle.Fill  // style
            };



            // Declare a signInView interface instance.
            ISignInView signInView = SignIn;
            ISignUpView signUpView = SignUp;
            IRecovery1View recovery1View = Recovery1;
            IRecovery2View recovery2View = Recovery2;


            //Dependency Injection
            new SignInPresenter(accountRepository, signInView);
            new SignUpPresenter(accountRepository, signUpView);
            new RecoveryPresenter(accountRepository, recovery1View, recovery2View);



            // inserting usercontrols in the panel
            MainFormLeftPanel.Controls.Add(pagination); //left
            MainFormRightPanel.Controls.Add(SignIn); //right
            MainFormRightPanel.Controls.Add(SignUp);
            MainFormRightPanel.Controls.Add(Recovery1);
            MainFormRightPanel.Controls.Add(Recovery2);
            MainFormRightPanel.Controls.Add(Confirmation);



        }
    }
}
