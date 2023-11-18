namespace BudgetBuddy
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MainFormRightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MainFormLeftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 28;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // MainFormRightPanel
            // 
            this.MainFormRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainFormRightPanel.Location = new System.Drawing.Point(640, 0);
            this.MainFormRightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainFormRightPanel.Name = "MainFormRightPanel";
            this.MainFormRightPanel.Size = new System.Drawing.Size(640, 800);
            this.MainFormRightPanel.TabIndex = 0;
            // 
            // MainFormLeftPanel
            // 
            this.MainFormLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainFormLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.MainFormLeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainFormLeftPanel.Name = "MainFormLeftPanel";
            this.MainFormLeftPanel.Size = new System.Drawing.Size(640, 800);
            this.MainFormLeftPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.MainFormLeftPanel);
            this.Controls.Add(this.MainFormRightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel MainFormLeftPanel;
        private Guna.UI2.WinForms.Guna2Panel MainFormRightPanel;
    }
}

