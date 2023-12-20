using BudgetBuddy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Views.UserControls
{
    public partial class Profile : UserControl, IProfileView
    {
        public Dashboard1 Dashboard1 { get; set; }
        public string NewFirstName
        {
            get { return FirstNameTxtBox.Text; }
            set { FirstNameTxtBox.Text = value; }
        }
        public string NewLastName
        {
            get { return LastNameTxtBox.Text; }
            set { LastNameTxtBox.Text = value; }
        }
        public string NewPassword
        {
            get { return ChangePassTxtBox.Text.Trim(); }
            set { ChangePassTxtBox.Text = value; }
        }
        public string Profile_Src {get; set; }
        public bool isSuccessful { get; set; }
        public FlowLayoutPanel VoucherPanel
        {
            get { return voucherPanel; }
            set {  voucherPanel = value; }

        }

        public Profile(Dashboard1 dashboard)
        {
            InitializeComponent();
            Dashboard1 = dashboard;
            AssociateAndRaiseViewEvents();

        }

        public event EventHandler UploadImageEvent;
        public event EventHandler UpdateProfileEvent;
        public event EventHandler LoadProfileEvent;

        private void AssociateAndRaiseViewEvents()
        {
            this.Load += delegate
            {
                string[] s = { "\\bin" };
                string appPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + @"\Resources\UserProfile\";


                LoadProfileEvent?.Invoke(this, EventArgs.Empty);


                if (Profile_Src != string.Empty)
                {
                    FirstNameTxtBox.Text = NewFirstName;
                    LastNameTxtBox.Text = NewLastName;
                    ProfilePicture.Image = new Bitmap(appPath + Profile_Src);
                }
                else
                {
                    ProfilePicture.Image = Properties.Resources.user;
                }

            };

            ConfirmBtn.Click += delegate
            {

                if (FirstNameTxtBox.Text != string.Empty &&
                LastNameTxtBox.Text != string.Empty &&
                ChangePassTxtBox.Text != string.Empty &&
                ConfirmPassTxtbox.Text != string.Empty &&
                ChangePassTxtBox.Text == ConfirmPassTxtbox.Text &&
                ChangePassTxtBox.Text.Length >= 8)
                {
                    UpdateProfileEvent?.Invoke(this, EventArgs.Empty);

                    if (isSuccessful)
                    {
                        MessageBox.Show("Profile Updated");

                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");

                    }


                }
                else
                {
                    MessageBox.Show("make sure you completed the form correctly");
                
                
                }
            };


            CancelBtn.Click += delegate
            {
                Dashboard1.DBPanel.Controls.Clear();
                Dashboard1.DBPanel.Controls.Add(Dashboard1.Overview);

            };


            EditProfilePic.Click += delegate
            {


                string[] s = { "\\bin" };
                string appPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + @"\Resources\UserProfile\";

                if (Directory.Exists(appPath) == false)                                              // <---
                {                                                                                    // <---
                    Directory.CreateDirectory(appPath);                                              // <---
                }                                                                                    // <---

                using (OpenFileDialog opnfd = new OpenFileDialog())
                {
                    opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";


                    if (opnfd.ShowDialog() == DialogResult.OK)
                    {
                        ProfilePicture.Image.Dispose();
                        Dashboard1.ProfileCircleBtn.Image.Dispose();

                        try
                        {

                            string iName = opnfd.SafeFileName;   // <---
                            string filepath = opnfd.FileName;    // <---

                            var new_name = Session.CurrentUser.ToString().Split('@')[0] + "_profile." + iName.Split('.')[1];
         
                            File.Copy(filepath, appPath + new_name, true); // <---

                            Profile_Src = new_name;
                            UploadImageEvent?.Invoke(this, EventArgs.Empty);

                            ProfilePicture.Image = new Bitmap(opnfd.OpenFile());
                            Dashboard1.ProfileCircleBtn.Image = new Bitmap(opnfd.OpenFile());

                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show("Unable to open file " + exp.Message);

                        }
                    }
                }

                    
            };
        }
    }
}
