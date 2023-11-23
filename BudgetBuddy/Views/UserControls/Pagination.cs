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

        private void Pagination_Load(object sender, EventArgs e)
        {
            Resources.Page1 page1 = new Resources.Page1
            {
                Dock = DockStyle.Fill
            };
            PaginationPanel.Controls.Add(page1);
        }
    }
}
