using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Views
{
    public interface IVouchersView
    {
        event EventHandler LoadVouchersEvent;
        event EventHandler LoadPointsEvent;

        FlowLayoutPanel VoucherPanel { get; set; }
        string user_points { get; set; }

    }
}
