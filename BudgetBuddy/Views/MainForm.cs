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
        public Recovery Recovery { get; set; }
        public Confirmation Confirmation { get; set; }



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
            Recovery = new Recovery(this)
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
            IRecoveryView recoveryView = Recovery;

            //Dependency Injection
            new SignInPresenter(accountRepository, signInView);
            new SignUpPresenter(accountRepository, signUpView);
            new RecoveryPresenter(accountRepository, recoveryView);



            // inserting usercontrols in the panel
            MainFormLeftPanel.Controls.Add(pagination); //left
            MainFormRightPanel.Controls.Add(SignIn); //right
            MainFormRightPanel.Controls.Add(SignUp);
            MainFormRightPanel.Controls.Add(Recovery);
            MainFormRightPanel.Controls.Add(Confirmation);


        }
    }
}
