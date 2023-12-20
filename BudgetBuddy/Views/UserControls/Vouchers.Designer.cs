namespace BudgetBuddy.Views.UserControls
{
    partial class Vouchers
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
            this.voucherPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MyPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Vouchers";
            // 
            // voucherPanel
            // 
            this.voucherPanel.Location = new System.Drawing.Point(56, 91);
            this.voucherPanel.Name = "voucherPanel";
            this.voucherPanel.Size = new System.Drawing.Size(1307, 532);
            this.voucherPanel.TabIndex = 22;
            // 
            // MyPoints
            // 
            this.MyPoints.AutoSize = true;
            this.MyPoints.BackColor = System.Drawing.Color.Transparent;
            this.MyPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyPoints.ForeColor = System.Drawing.Color.White;
            this.MyPoints.Location = new System.Drawing.Point(1067, 34);
            this.MyPoints.Name = "MyPoints";
            this.MyPoints.Size = new System.Drawing.Size(161, 33);
            this.MyPoints.TabIndex = 23;
            this.MyPoints.Text = "My Points:";
            // 
            // Vouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.MyPoints);
            this.Controls.Add(this.voucherPanel);
            this.Controls.Add(this.label1);
            this.Name = "Vouchers";
            this.Size = new System.Drawing.Size(1440, 954);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel voucherPanel;
        private System.Windows.Forms.Label MyPoints;
    }
}
