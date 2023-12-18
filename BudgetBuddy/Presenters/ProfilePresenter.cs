using BudgetBuddy.Models;
using BudgetBuddy.Repositories;
using BudgetBuddy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Presenters
{
    public class ProfilePresenter
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IProfileView _view;

        public ProfilePresenter(IAccountRepository accountRepository, IProfileView view)
        {

            _accountRepository = accountRepository;
            _view = view;


            _view.UploadImageEvent += UploadImage;
            _view.UpdateProfileEvent += UpdateProfile;
            _view.LoadProfileEvent += LoadProfile;
        }

        private void LoadProfile(object sender, EventArgs e)
        {
            try
            {
                if (_accountRepository.GetProfile() != null)
                {
                    var profile = _accountRepository.GetProfile();

                    _view.Profile_Src = profile.profile_src;
                    _view.NewFirstName = profile.first_name;
                    _view.NewLastName = profile.last_name;

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

        private void UpdateProfile(object sender, EventArgs e)
        {
            try
            {

                var newpass = new user
                {
                    password_hash = _view.NewPassword

                };
                var newdetails = new user_detail
                {
                    first_name = _view.NewFirstName,
                    last_name = _view.NewLastName

                };

                if (_accountRepository.UpdateProfile(newpass, newdetails))
                {
                    _view.isSuccessful = true;
                }
                else
                {
                    _view.isSuccessful = false;
                }
                

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void UploadImage(object sender, EventArgs e)
        {
            try
            {
                _accountRepository.UploadProfilePicture(_view.Profile_Src);
            }
            catch
            {

            }
       
        }
    }
}
