namespace BudgetBuddy.Resources.Components
{
    partial class VoucherComponent
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
            this.voucher_name = new System.Windows.Forms.Label();
            this.redeemBtn = new Guna.UI2.WinForms.Guna2Button();
            this.voucher_type = new System.Windows.Forms.Label();
            this.voucher_reward = new System.Windows.Forms.Label();
            this.required_points = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voucher_name
            // 
            this.voucher_name.AutoSize = true;
            this.voucher_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucher_name.Location = new System.Drawing.Point(136, 15);
            this.voucher_name.Name = "voucher_name";
            this.voucher_name.Size = new System.Drawing.Size(121, 20);
            this.voucher_name.TabIndex = 0;
            this.voucher_name.Text = "SavvySaver25";
            // 
            // redeemBtn
            // 
            this.redeemBtn.DefaultAutoSize = true;
            this.redeemBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.redeemBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.redeemBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.redeemBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.redeemBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.redeemBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.redeemBtn.ForeColor = System.Drawing.Color.White;
            this.redeemBtn.Location = new System.Drawing.Point(140, 59);
            this.redeemBtn.Name = "redeemBtn";
            this.redeemBtn.Size = new System.Drawing.Size(74, 27);
            this.redeemBtn.TabIndex = 1;
            this.redeemBtn.Text = "Redeem";
            // 
            // voucher_type
            // 
            this.voucher_type.AutoSize = true;
            this.voucher_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucher_type.Location = new System.Drawing.Point(14, 70);
            this.voucher_type.Name = "voucher_type";
            this.voucher_type.Size = new System.Drawing.Size(59, 16);
            this.voucher_type.TabIndex = 2;
            this.voucher_type.Text = "Discount";
            // 
            // voucher_reward
            // 
            this.voucher_reward.AutoSize = true;
            this.voucher_reward.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucher_reward.Location = new System.Drawing.Point(7, 15);
            this.voucher_reward.Name = "voucher_reward";
            this.voucher_reward.Size = new System.Drawing.Size(124, 55);
            this.voucher_reward.TabIndex = 3;
            this.voucher_reward.Text = "24%";
            // 
            // required_points
            // 
            this.required_points.AutoSize = true;
            this.required_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.required_points.Location = new System.Drawing.Point(137, 40);
            this.required_points.Name = "required_points";
            this.required_points.Size = new System.Drawing.Size(106, 16);
            this.required_points.TabIndex = 4;
            this.required_points.Text = "Required Points:";
            // 
            // VoucherComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.required_points);
            this.Controls.Add(this.voucher_reward);
            this.Controls.Add(this.voucher_type);
            this.Controls.Add(this.redeemBtn);
            this.Controls.Add(this.voucher_name);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "VoucherComponent";
            this.Size = new System.Drawing.Size(280, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label voucher_name;
        private Guna.UI2.WinForms.Guna2Button redeemBtn;
        private System.Windows.Forms.Label voucher_type;
        private System.Windows.Forms.Label voucher_reward;
        private System.Windows.Forms.Label required_points;
    }
}
