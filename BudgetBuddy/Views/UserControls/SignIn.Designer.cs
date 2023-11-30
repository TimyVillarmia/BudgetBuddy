namespace BudgetBuddy.Presenters.UserControls
{
    partial class SignIn
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
            this.components = new System.ComponentModel.Container();
            this.HeadlineLbl = new System.Windows.Forms.Label();
            this.EmailTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignInBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RecoveryLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SignupLbl = new System.Windows.Forms.LinkLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PasswordState = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadlineLbl
            // 
            this.HeadlineLbl.AutoSize = true;
            this.HeadlineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadlineLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.HeadlineLbl.Location = new System.Drawing.Point(109, 189);
            this.HeadlineLbl.Name = "HeadlineLbl";
            this.HeadlineLbl.Size = new System.Drawing.Size(356, 165);
            this.HeadlineLbl.TabIndex = 0;
            this.HeadlineLbl.Text = "Sign In to \r\nYour Personal \r\nFinance Hub";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxtBox.DefaultText = "";
            this.EmailTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.EmailTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtBox.Location = new System.Drawing.Point(119, 425);
            this.EmailTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.PasswordChar = '\0';
            this.EmailTxtBox.PlaceholderText = "";
            this.EmailTxtBox.SelectedText = "";
            this.EmailTxtBox.Size = new System.Drawing.Size(400, 36);
            this.EmailTxtBox.TabIndex = 1;
            this.EmailTxtBox.TextChanged += new System.EventHandler(this.EmailTxtBox_TextChanged);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxtBox.DefaultText = "";
            this.PasswordTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.PasswordTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtBox.Location = new System.Drawing.Point(119, 518);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.PlaceholderText = "";
            this.PasswordTxtBox.SelectedText = "";
            this.PasswordTxtBox.Size = new System.Drawing.Size(400, 36);
            this.PasswordTxtBox.TabIndex = 2;
            this.PasswordTxtBox.TextChanged += new System.EventHandler(this.PasswordTxtBox_TextChanged);
            // 
            // SignInBtn
            // 
            this.SignInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignInBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(9)))));
            this.SignInBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.ForeColor = System.Drawing.Color.White;
            this.SignInBtn.Location = new System.Drawing.Point(119, 611);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(400, 45);
            this.SignInBtn.TabIndex = 3;
            this.SignInBtn.Text = "Sign in";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.label2.Location = new System.Drawing.Point(0, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(640, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Securely Access Your Financial Journey";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(92)))));
            this.EmailLbl.Location = new System.Drawing.Point(115, 402);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(48, 20);
            this.EmailLbl.TabIndex = 7;
            this.EmailLbl.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(92)))));
            this.label4.Location = new System.Drawing.Point(115, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // RecoveryLbl
            // 
            this.RecoveryLbl.AutoSize = true;
            this.RecoveryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(92)))));
            this.RecoveryLbl.Location = new System.Drawing.Point(403, 561);
            this.RecoveryLbl.Name = "RecoveryLbl";
            this.RecoveryLbl.Size = new System.Drawing.Size(116, 16);
            this.RecoveryLbl.TabIndex = 9;
            this.RecoveryLbl.Text = "Forgot Password?";
            this.RecoveryLbl.Click += new System.EventHandler(this.RecoveryLbl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(92)))));
            this.label6.Location = new System.Drawing.Point(186, 700);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Don’t have an account? ";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // SignupLbl
            // 
            this.SignupLbl.AutoSize = true;
            this.SignupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SignupLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(49)))), ((int)(((byte)(112)))));
            this.SignupLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(49)))), ((int)(((byte)(112)))));
            this.SignupLbl.Location = new System.Drawing.Point(365, 700);
            this.SignupLbl.Name = "SignupLbl";
            this.SignupLbl.Size = new System.Drawing.Size(63, 20);
            this.SignupLbl.TabIndex = 33;
            this.SignupLbl.TabStop = true;
            this.SignupLbl.Text = "Sign up";
            this.SignupLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignupLbl_LinkClicked);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::BudgetBuddy.Properties.Resources.logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 56);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(640, 68);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 13;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // PasswordState
            // 
            this.PasswordState.BackColor = System.Drawing.Color.White;
            this.PasswordState.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.PasswordState.CheckedState.FillColor = System.Drawing.Color.White;
            this.PasswordState.CheckedState.Image = global::BudgetBuddy.Properties.Resources.Show;
            this.PasswordState.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PasswordState.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PasswordState.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PasswordState.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PasswordState.FillColor = System.Drawing.Color.Transparent;
            this.PasswordState.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordState.ForeColor = System.Drawing.Color.White;
            this.PasswordState.Image = global::BudgetBuddy.Properties.Resources.Hide;
            this.PasswordState.ImageSize = new System.Drawing.Size(25, 25);
            this.PasswordState.Location = new System.Drawing.Point(489, 524);
            this.PasswordState.Name = "PasswordState";
            this.PasswordState.PressedColor = System.Drawing.Color.Transparent;
            this.PasswordState.Size = new System.Drawing.Size(25, 25);
            this.PasswordState.TabIndex = 35;
            this.PasswordState.CheckedChanged += new System.EventHandler(this.PasswordState_CheckedChanged);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(592, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 50;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.PasswordState);
            this.Controls.Add(this.SignupLbl);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RecoveryLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.HeadlineLbl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SignIn";
            this.Size = new System.Drawing.Size(640, 800);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadlineLbl;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxtBox;
        private Guna.UI2.WinForms.Guna2Button SignInBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RecoveryLbl;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.LinkLabel SignupLbl;
        private Guna.UI2.WinForms.Guna2Button PasswordState;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}
