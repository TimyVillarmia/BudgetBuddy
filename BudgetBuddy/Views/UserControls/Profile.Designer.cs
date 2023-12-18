namespace BudgetBuddy.Views.UserControls
{
    partial class Profile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditProfilePic = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HeadlineLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ConfirmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProfilePicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ConfirmPassTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangePassTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // EditProfilePic
            // 
            this.EditProfilePic.BackColor = System.Drawing.Color.White;
            this.EditProfilePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProfilePic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.EditProfilePic.Location = new System.Drawing.Point(58, 312);
            this.EditProfilePic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditProfilePic.Name = "EditProfilePic";
            this.EditProfilePic.Size = new System.Drawing.Size(92, 25);
            this.EditProfilePic.TabIndex = 1;
            this.EditProfilePic.Text = "Edit Profile";
            // 
            // HeadlineLbl
            // 
            this.HeadlineLbl.AutoSize = true;
            this.HeadlineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadlineLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.HeadlineLbl.Location = new System.Drawing.Point(50, 27);
            this.HeadlineLbl.Name = "HeadlineLbl";
            this.HeadlineLbl.Size = new System.Drawing.Size(166, 55);
            this.HeadlineLbl.TabIndex = 8;
            this.HeadlineLbl.Text = "Profile";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.NameLbl.Location = new System.Drawing.Point(263, 87);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(148, 29);
            this.NameLbl.TabIndex = 11;
            this.NameLbl.Text = "First Name:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.ConfirmBtn);
            this.guna2Panel1.Controls.Add(this.EditProfilePic);
            this.guna2Panel1.Controls.Add(this.CancelBtn);
            this.guna2Panel1.Controls.Add(this.ProfilePicture);
            this.guna2Panel1.Controls.Add(this.ConfirmPassTxtbox);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.ChangePassTxtBox);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.LastNameTxtBox);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.FirstNameTxtBox);
            this.guna2Panel1.Controls.Add(this.HeadlineLbl);
            this.guna2Panel1.Controls.Add(this.NameLbl);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1440, 954);
            this.guna2Panel1.TabIndex = 14;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BorderRadius = 8;
            this.ConfirmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConfirmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConfirmBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ConfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmBtn.Location = new System.Drawing.Point(1133, 900);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(137, 30);
            this.ConfirmBtn.TabIndex = 31;
            this.ConfirmBtn.Text = "Confirm";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.CancelBtn.BorderRadius = 8;
            this.CancelBtn.BorderThickness = 1;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.FillColor = System.Drawing.Color.Transparent;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.CancelBtn.Location = new System.Drawing.Point(1276, 900);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(137, 30);
            this.CancelBtn.TabIndex = 30;
            this.CancelBtn.Text = "Cancel";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackColor = System.Drawing.Color.Black;
            this.ProfilePicture.ImageRotate = 0F;
            this.ProfilePicture.Location = new System.Drawing.Point(58, 87);
            this.ProfilePicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(188, 203);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 0;
            this.ProfilePicture.TabStop = false;
            // 
            // ConfirmPassTxtbox
            // 
            this.ConfirmPassTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPassTxtbox.DefaultText = "";
            this.ConfirmPassTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmPassTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmPassTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPassTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPassTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPassTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConfirmPassTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPassTxtbox.Location = new System.Drawing.Point(994, 167);
            this.ConfirmPassTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmPassTxtbox.Name = "ConfirmPassTxtbox";
            this.ConfirmPassTxtbox.PasswordChar = '\0';
            this.ConfirmPassTxtbox.PlaceholderText = "";
            this.ConfirmPassTxtbox.SelectedText = "";
            this.ConfirmPassTxtbox.Size = new System.Drawing.Size(276, 29);
            this.ConfirmPassTxtbox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(740, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Confirm Password:";
            // 
            // ChangePassTxtBox
            // 
            this.ChangePassTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChangePassTxtBox.DefaultText = "";
            this.ChangePassTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ChangePassTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ChangePassTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ChangePassTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ChangePassTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChangePassTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangePassTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChangePassTxtBox.Location = new System.Drawing.Point(994, 87);
            this.ChangePassTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangePassTxtBox.Name = "ChangePassTxtBox";
            this.ChangePassTxtBox.PasswordChar = '\0';
            this.ChangePassTxtBox.PlaceholderText = "";
            this.ChangePassTxtBox.SelectedText = "";
            this.ChangePassTxtBox.Size = new System.Drawing.Size(276, 29);
            this.ChangePassTxtBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(741, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Change Password:";
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNameTxtBox.DefaultText = "";
            this.LastNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LastNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LastNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LastNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastNameTxtBox.Location = new System.Drawing.Point(421, 167);
            this.LastNameTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.PasswordChar = '\0';
            this.LastNameTxtBox.PlaceholderText = "";
            this.LastNameTxtBox.SelectedText = "";
            this.LastNameTxtBox.Size = new System.Drawing.Size(276, 29);
            this.LastNameTxtBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(263, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Last Name:";
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstNameTxtBox.DefaultText = "";
            this.FirstNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FirstNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FirstNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirstNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstNameTxtBox.Location = new System.Drawing.Point(421, 87);
            this.FirstNameTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.PasswordChar = '\0';
            this.FirstNameTxtBox.PlaceholderText = "";
            this.FirstNameTxtBox.SelectedText = "";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(276, 29);
            this.FirstNameTxtBox.TabIndex = 14;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(1440, 954);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox ProfilePicture;
        private Guna.UI2.WinForms.Guna2HtmlLabel EditProfilePic;
        private System.Windows.Forms.Label HeadlineLbl;
        private System.Windows.Forms.Label NameLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox LastNameTxtBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox FirstNameTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmPassTxtbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox ChangePassTxtBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button ConfirmBtn;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
    }
}
