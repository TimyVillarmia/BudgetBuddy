namespace BudgetBuddy.Views.UserControls
{
    partial class Confirmation
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HeadlineLbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.placeholder = new System.Windows.Forms.Label();
            this.firstDigitOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.secondDigitOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.thirdDigitOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.fourthDigitOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.fifthDigitOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.sixthDigitOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.ResendLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ConfirmBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.label2.Location = new System.Drawing.Point(63, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 50);
            this.label2.TabIndex = 18;
            this.label2.Text = "To help keep your account safe, We want to \r\nmake sure it’s really you trying to " +
    "access";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeadlineLbl
            // 
            this.HeadlineLbl.AutoSize = true;
            this.HeadlineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadlineLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.HeadlineLbl.Location = new System.Drawing.Point(58, 231);
            this.HeadlineLbl.Name = "HeadlineLbl";
            this.HeadlineLbl.Size = new System.Drawing.Size(278, 55);
            this.HeadlineLbl.TabIndex = 17;
            this.HeadlineLbl.Text = "Enter Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.label1.Location = new System.Drawing.Point(63, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "An email with a verification code was just sent to ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // placeholder
            // 
            this.placeholder.AutoSize = true;
            this.placeholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.placeholder.Location = new System.Drawing.Point(63, 382);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(124, 25);
            this.placeholder.TabIndex = 21;
            this.placeholder.Text = "placeholder";
            this.placeholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstDigitOTP
            // 
            this.firstDigitOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstDigitOTP.DefaultText = "";
            this.firstDigitOTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstDigitOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstDigitOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstDigitOTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstDigitOTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstDigitOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.firstDigitOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.firstDigitOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstDigitOTP.Location = new System.Drawing.Point(68, 443);
            this.firstDigitOTP.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.firstDigitOTP.MaxLength = 1;
            this.firstDigitOTP.Name = "firstDigitOTP";
            this.firstDigitOTP.PasswordChar = '\0';
            this.firstDigitOTP.PlaceholderText = "0";
            this.firstDigitOTP.SelectedText = "";
            this.firstDigitOTP.Size = new System.Drawing.Size(75, 75);
            this.firstDigitOTP.TabIndex = 22;
            this.firstDigitOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // secondDigitOTP
            // 
            this.secondDigitOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secondDigitOTP.DefaultText = "";
            this.secondDigitOTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.secondDigitOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.secondDigitOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secondDigitOTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secondDigitOTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secondDigitOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.secondDigitOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.secondDigitOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secondDigitOTP.Location = new System.Drawing.Point(149, 443);
            this.secondDigitOTP.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.secondDigitOTP.MaxLength = 1;
            this.secondDigitOTP.Name = "secondDigitOTP";
            this.secondDigitOTP.PasswordChar = '\0';
            this.secondDigitOTP.PlaceholderText = "0";
            this.secondDigitOTP.SelectedText = "";
            this.secondDigitOTP.Size = new System.Drawing.Size(75, 75);
            this.secondDigitOTP.TabIndex = 24;
            this.secondDigitOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thirdDigitOTP
            // 
            this.thirdDigitOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.thirdDigitOTP.DefaultText = "";
            this.thirdDigitOTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.thirdDigitOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.thirdDigitOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thirdDigitOTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thirdDigitOTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thirdDigitOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.thirdDigitOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.thirdDigitOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thirdDigitOTP.Location = new System.Drawing.Point(230, 443);
            this.thirdDigitOTP.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.thirdDigitOTP.MaxLength = 1;
            this.thirdDigitOTP.Name = "thirdDigitOTP";
            this.thirdDigitOTP.PasswordChar = '\0';
            this.thirdDigitOTP.PlaceholderText = "0";
            this.thirdDigitOTP.SelectedText = "";
            this.thirdDigitOTP.Size = new System.Drawing.Size(75, 75);
            this.thirdDigitOTP.TabIndex = 25;
            this.thirdDigitOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fourthDigitOTP
            // 
            this.fourthDigitOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fourthDigitOTP.DefaultText = "";
            this.fourthDigitOTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fourthDigitOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fourthDigitOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fourthDigitOTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fourthDigitOTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fourthDigitOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.fourthDigitOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.fourthDigitOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fourthDigitOTP.Location = new System.Drawing.Point(311, 443);
            this.fourthDigitOTP.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.fourthDigitOTP.MaxLength = 1;
            this.fourthDigitOTP.Name = "fourthDigitOTP";
            this.fourthDigitOTP.PasswordChar = '\0';
            this.fourthDigitOTP.PlaceholderText = "0";
            this.fourthDigitOTP.SelectedText = "";
            this.fourthDigitOTP.Size = new System.Drawing.Size(75, 75);
            this.fourthDigitOTP.TabIndex = 26;
            this.fourthDigitOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fifthDigitOTP
            // 
            this.fifthDigitOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fifthDigitOTP.DefaultText = "";
            this.fifthDigitOTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fifthDigitOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fifthDigitOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fifthDigitOTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fifthDigitOTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fifthDigitOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.fifthDigitOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.fifthDigitOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fifthDigitOTP.Location = new System.Drawing.Point(392, 443);
            this.fifthDigitOTP.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.fifthDigitOTP.MaxLength = 1;
            this.fifthDigitOTP.Name = "fifthDigitOTP";
            this.fifthDigitOTP.PasswordChar = '\0';
            this.fifthDigitOTP.PlaceholderText = "0";
            this.fifthDigitOTP.SelectedText = "";
            this.fifthDigitOTP.Size = new System.Drawing.Size(75, 75);
            this.fifthDigitOTP.TabIndex = 27;
            this.fifthDigitOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sixthDigitOTP
            // 
            this.sixthDigitOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sixthDigitOTP.DefaultText = "";
            this.sixthDigitOTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sixthDigitOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sixthDigitOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sixthDigitOTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sixthDigitOTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sixthDigitOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.sixthDigitOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.sixthDigitOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sixthDigitOTP.Location = new System.Drawing.Point(473, 443);
            this.sixthDigitOTP.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.sixthDigitOTP.MaxLength = 1;
            this.sixthDigitOTP.Name = "sixthDigitOTP";
            this.sixthDigitOTP.PasswordChar = '\0';
            this.sixthDigitOTP.PlaceholderText = "0";
            this.sixthDigitOTP.SelectedText = "";
            this.sixthDigitOTP.Size = new System.Drawing.Size(75, 75);
            this.sixthDigitOTP.TabIndex = 28;
            this.sixthDigitOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResendLbl
            // 
            this.ResendLbl.AutoSize = true;
            this.ResendLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResendLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(49)))), ((int)(((byte)(112)))));
            this.ResendLbl.Location = new System.Drawing.Point(441, 551);
            this.ResendLbl.Name = "ResendLbl";
            this.ResendLbl.Size = new System.Drawing.Size(107, 20);
            this.ResendLbl.TabIndex = 29;
            this.ResendLbl.Text = "Resend Code";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(9)))));
            this.CancelBtn.BorderRadius = 4;
            this.CancelBtn.BorderThickness = 1;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.FillColor = System.Drawing.Color.Transparent;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(9)))));
            this.CancelBtn.Location = new System.Drawing.Point(68, 596);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(230, 45);
            this.CancelBtn.TabIndex = 30;
            this.CancelBtn.Text = "Cancel";
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BorderRadius = 4;
            this.ConfirmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConfirmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConfirmBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(9)))));
            this.ConfirmBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmBtn.Location = new System.Drawing.Point(318, 596);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(230, 45);
            this.ConfirmBtn.TabIndex = 31;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ResendLbl);
            this.Controls.Add(this.sixthDigitOTP);
            this.Controls.Add(this.fifthDigitOTP);
            this.Controls.Add(this.fourthDigitOTP);
            this.Controls.Add(this.thirdDigitOTP);
            this.Controls.Add(this.secondDigitOTP);
            this.Controls.Add(this.firstDigitOTP);
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeadlineLbl);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "Confirmation";
            this.Size = new System.Drawing.Size(640, 800);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HeadlineLbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label placeholder;
        private Guna.UI2.WinForms.Guna2TextBox firstDigitOTP;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2TextBox secondDigitOTP;
        private Guna.UI2.WinForms.Guna2TextBox thirdDigitOTP;
        private Guna.UI2.WinForms.Guna2TextBox fourthDigitOTP;
        private Guna.UI2.WinForms.Guna2TextBox fifthDigitOTP;
        private Guna.UI2.WinForms.Guna2TextBox sixthDigitOTP;
        private System.Windows.Forms.Label ResendLbl;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        private Guna.UI2.WinForms.Guna2Button ConfirmBtn;
    }
}
