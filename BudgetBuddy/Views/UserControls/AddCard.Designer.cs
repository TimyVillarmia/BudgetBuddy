namespace BudgetBuddy.Views.UserControls
{
    partial class AddCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CardNumberTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ConfirmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PINTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExpiryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.EmailTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.AccountTypeCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Information";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.AccountTypeCombo);
            this.guna2Panel1.Controls.Add(this.CardNumberTxtbox);
            this.guna2Panel1.Controls.Add(this.CancelBtn);
            this.guna2Panel1.Controls.Add(this.ConfirmBtn);
            this.guna2Panel1.Controls.Add(this.PINTxtbox);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.ExpiryDate);
            this.guna2Panel1.Controls.Add(this.EmailTxtbox);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.NameTxtbox);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(613, 274);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(625, 676);
            this.guna2Panel1.TabIndex = 1;
            // 
            // CardNumberTxtbox
            // 
            this.CardNumberTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CardNumberTxtbox.DefaultText = "";
            this.CardNumberTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CardNumberTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CardNumberTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CardNumberTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CardNumberTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CardNumberTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CardNumberTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CardNumberTxtbox.Location = new System.Drawing.Point(33, 151);
            this.CardNumberTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CardNumberTxtbox.Name = "CardNumberTxtbox";
            this.CardNumberTxtbox.PasswordChar = '\0';
            this.CardNumberTxtbox.PlaceholderText = "";
            this.CardNumberTxtbox.SelectedText = "";
            this.CardNumberTxtbox.Size = new System.Drawing.Size(556, 44);
            this.CardNumberTxtbox.TabIndex = 21;
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
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.CancelBtn.Location = new System.Drawing.Point(323, 564);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(268, 55);
            this.CancelBtn.TabIndex = 20;
            this.CancelBtn.Text = "Cancel";
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BorderRadius = 8;
            this.ConfirmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConfirmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConfirmBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmBtn.Location = new System.Drawing.Point(41, 564);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(261, 55);
            this.ConfirmBtn.TabIndex = 13;
            this.ConfirmBtn.Text = "Confirm";
            // 
            // PINTxtbox
            // 
            this.PINTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PINTxtbox.DefaultText = "";
            this.PINTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PINTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PINTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PINTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PINTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PINTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PINTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PINTxtbox.Location = new System.Drawing.Point(323, 486);
            this.PINTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PINTxtbox.Name = "PINTxtbox";
            this.PINTxtbox.PasswordChar = '\0';
            this.PINTxtbox.PlaceholderText = "";
            this.PINTxtbox.SelectedText = "";
            this.PINTxtbox.Size = new System.Drawing.Size(268, 44);
            this.PINTxtbox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 447);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "PIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 447);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Expiry Date";
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.Checked = true;
            this.ExpiryDate.CustomFormat = "yyyy-MM-dd";
            this.ExpiryDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ExpiryDate.Location = new System.Drawing.Point(36, 486);
            this.ExpiryDate.Margin = new System.Windows.Forms.Padding(4);
            this.ExpiryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ExpiryDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.Size = new System.Drawing.Size(267, 44);
            this.ExpiryDate.TabIndex = 9;
            this.ExpiryDate.Value = new System.DateTime(2023, 12, 4, 20, 58, 25, 799);
            // 
            // EmailTxtbox
            // 
            this.EmailTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxtbox.DefaultText = "";
            this.EmailTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtbox.Location = new System.Drawing.Point(36, 366);
            this.EmailTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailTxtbox.Name = "EmailTxtbox";
            this.EmailTxtbox.PasswordChar = '\0';
            this.EmailTxtbox.PlaceholderText = "";
            this.EmailTxtbox.SelectedText = "";
            this.EmailTxtbox.Size = new System.Drawing.Size(555, 44);
            this.EmailTxtbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // NameTxtbox
            // 
            this.NameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxtbox.DefaultText = "";
            this.NameTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxtbox.Location = new System.Drawing.Point(35, 260);
            this.NameTxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTxtbox.Name = "NameTxtbox";
            this.NameTxtbox.PasswordChar = '\0';
            this.NameTxtbox.PlaceholderText = "";
            this.NameTxtbox.SelectedText = "";
            this.NameTxtbox.Size = new System.Drawing.Size(556, 44);
            this.NameTxtbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account Number";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(-4, 73);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(728, 12);
            this.guna2Separator1.TabIndex = 1;
            // 
            // AccountTypeCombo
            // 
            this.AccountTypeCombo.BackColor = System.Drawing.Color.Transparent;
            this.AccountTypeCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AccountTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountTypeCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AccountTypeCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AccountTypeCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AccountTypeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AccountTypeCombo.ItemHeight = 30;
            this.AccountTypeCombo.Items.AddRange(new object[] {
            "Checking",
            "Savings"});
            this.AccountTypeCombo.Location = new System.Drawing.Point(382, 27);
            this.AccountTypeCombo.Name = "AccountTypeCombo";
            this.AccountTypeCombo.Size = new System.Drawing.Size(209, 36);
            this.AccountTypeCombo.TabIndex = 22;
            // 
            // AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCard";
            this.Size = new System.Drawing.Size(1920, 1174);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox PINTxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker ExpiryDate;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxtbox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox NameTxtbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button ConfirmBtn;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        private Guna.UI2.WinForms.Guna2TextBox CardNumberTxtbox;
        private Guna.UI2.WinForms.Guna2ComboBox AccountTypeCombo;
    }
}
