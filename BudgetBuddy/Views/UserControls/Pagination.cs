using BudgetBuddy.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Presenters.UserControls
{
    public partial class Pagination : UserControl
    {
        public Pagination()
        {
            InitializeComponent();
        }
        private RadioButton selectedrb;
        public Page1 page1;
        public Page2 page2;
        public Page3 page3;


        private void Pagination_Load(object sender, EventArgs e)
        {
            page1 = new Resources.Page1
            {
                Dock = DockStyle.Fill
            };
            page2 = new Resources.Page2
            {
                Dock = DockStyle.Fill
            };

            page3 = new Resources.Page3
            {
                Dock = DockStyle.Fill
            };

            IndicatorGroupBox.Controls.Add(this.PaginationIndicator1);
            IndicatorGroupBox.Controls.Add(this.PaginationIndicator2);
            IndicatorGroupBox.Controls.Add(this.PaginationIndicator3);

            this.PaginationIndicator1.CheckedChanged += new EventHandler(radioButton_CheckedChange);
            this.PaginationIndicator2.CheckedChanged += new EventHandler(radioButton_CheckedChange);            this.PaginationIndicator1.CheckedChanged += new EventHandler(radioButton_CheckedChange);
            this.PaginationIndicator3.CheckedChanged += new EventHandler(radioButton_CheckedChange);




            PaginationPanel.Controls.Add(page1);
            PaginationPanel.Controls.Add(page2);
            PaginationPanel.Controls.Add(page3);



        }

        private void radioButton_CheckedChange(object sender, EventArgs e)
        {

            if (PaginationIndicator1.Checked)
            {
                page1.BringToFront();
            }
            if (PaginationIndicator2.Checked)
            {
                page2.BringToFront();
            }
            if (PaginationIndicator3.Checked)
            {
                page3.BringToFront();
            }
        }
    }
}
