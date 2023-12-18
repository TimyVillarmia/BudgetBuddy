using BudgetBuddy.Models;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Presenters
{
    public class DashboardPresenter
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IDashboardView _view;

        public DashboardPresenter(IAccountRepository accountRepository, IDashboardView view)
        {
            _accountRepository = accountRepository;
            _view = view;

            _view.LoadProfileEvent += LoadProfile;
        }

        private void LoadProfile(object sender, EventArgs e)
        {
            try
            {
                if (_accountRepository.GetProfile() != null)
                {
                    _view.Profile_Src = _accountRepository.GetProfile().profile_src;

                }
                else
                {
                    _view.Profile_Src = string.Empty;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
