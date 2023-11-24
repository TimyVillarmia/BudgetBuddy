namespace BudgetBuddy.Presenters.UserControls
{
    partial class Pagination
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagination));
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.PaginationPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.IndicatorGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.PaginationIndicator2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.PaginationIndicator1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.PaginationIndicator3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.IndicatorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // PaginationPanel
            // 
            this.guna2Transition1.SetDecoration(this.PaginationPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PaginationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaginationPanel.Location = new System.Drawing.Point(0, 0);
            this.PaginationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PaginationPanel.Name = "PaginationPanel";
            this.PaginationPanel.Size = new System.Drawing.Size(640, 702);
            this.PaginationPanel.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.guna2Transition1.SetDecoration(this.tabPage1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.guna2Transition1.SetDecoration(this.tabPage2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // IndicatorGroupBox
            // 
            this.IndicatorGroupBox.BorderColor = System.Drawing.Color.Transparent;
            this.IndicatorGroupBox.Controls.Add(this.PaginationIndicator2);
            this.IndicatorGroupBox.Controls.Add(this.PaginationIndicator1);
            this.IndicatorGroupBox.Controls.Add(this.PaginationIndicator3);
            this.IndicatorGroupBox.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.IndicatorGroupBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.IndicatorGroupBox.FillColor = System.Drawing.Color.Transparent;
            this.IndicatorGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IndicatorGroupBox.ForeColor = System.Drawing.Color.Transparent;
            this.IndicatorGroupBox.Location = new System.Drawing.Point(242, 706);
            this.IndicatorGroupBox.Name = "IndicatorGroupBox";
            this.IndicatorGroupBox.Size = new System.Drawing.Size(156, 62);
            this.IndicatorGroupBox.TabIndex = 6;
            // 
            // PaginationIndicator2
            // 
            this.PaginationIndicator2.AutoSize = true;
            this.PaginationIndicator2.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.PaginationIndicator2.CheckedState.BorderThickness = 0;
            this.PaginationIndicator2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.PaginationIndicator2.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.guna2Transition1.SetDecoration(this.PaginationIndicator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PaginationIndicator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PaginationIndicator2.Location = new System.Drawing.Point(70, 25);
            this.PaginationIndicator2.Name = "PaginationIndicator2";
            this.PaginationIndicator2.Size = new System.Drawing.Size(14, 13);
            this.PaginationIndicator2.TabIndex = 5;
            this.PaginationIndicator2.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.PaginationIndicator2.UncheckedState.BorderThickness = 2;
            this.PaginationIndicator2.UncheckedState.FillColor = System.Drawing.Color.White;
            this.PaginationIndicator2.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // PaginationIndicator1
            // 
            this.PaginationIndicator1.AutoSize = true;
            this.PaginationIndicator1.Checked = true;
            this.PaginationIndicator1.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.PaginationIndicator1.CheckedState.BorderThickness = 0;
            this.PaginationIndicator1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.PaginationIndicator1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.guna2Transition1.SetDecoration(this.PaginationIndicator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PaginationIndicator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PaginationIndicator1.Location = new System.Drawing.Point(44, 25);
            this.PaginationIndicator1.Name = "PaginationIndicator1";
            this.PaginationIndicator1.Size = new System.Drawing.Size(14, 13);
            this.PaginationIndicator1.TabIndex = 4;
            this.PaginationIndicator1.TabStop = true;
            this.PaginationIndicator1.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.PaginationIndicator1.UncheckedState.BorderThickness = 2;
            this.PaginationIndicator1.UncheckedState.FillColor = System.Drawing.Color.White;
            this.PaginationIndicator1.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // PaginationIndicator3
            // 
            this.PaginationIndicator3.AutoSize = true;
            this.PaginationIndicator3.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.PaginationIndicator3.CheckedState.BorderThickness = 0;
            this.PaginationIndicator3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.PaginationIndicator3.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(6)))));
            this.guna2Transition1.SetDecoration(this.PaginationIndicator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PaginationIndicator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PaginationIndicator3.Location = new System.Drawing.Point(98, 25);
            this.PaginationIndicator3.Name = "PaginationIndicator3";
            this.PaginationIndicator3.Size = new System.Drawing.Size(14, 13);
            this.PaginationIndicator3.TabIndex = 6;
            this.PaginationIndicator3.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.PaginationIndicator3.UncheckedState.BorderThickness = 2;
            this.PaginationIndicator3.UncheckedState.FillColor = System.Drawing.Color.White;
            this.PaginationIndicator3.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // Pagination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.IndicatorGroupBox);
            this.Controls.Add(this.PaginationPanel);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Pagination";
            this.Size = new System.Drawing.Size(640, 800);
            this.Load += new System.EventHandler(this.Pagination_Load);
            this.IndicatorGroupBox.ResumeLayout(false);
            this.IndicatorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Panel PaginationPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2GroupBox IndicatorGroupBox;
        private Guna.UI2.WinForms.Guna2RadioButton PaginationIndicator2;
        private Guna.UI2.WinForms.Guna2RadioButton PaginationIndicator1;
        private Guna.UI2.WinForms.Guna2RadioButton PaginationIndicator3;
    }
}
