using System;
using System.Windows.Forms;

namespace BudgetBuddy.Views
{
    public interface IProfileView
    {
        event EventHandler UploadImageEvent;
        event EventHandler UpdateProfileEvent;
        event EventHandler LoadProfileEvent;

        string Profile_Src { get; set; }
        string NewFirstName { get; set; }
        string NewLastName { get; set; }
        string NewPassword { get; set; }
        bool isSuccessful { get; set; }
        FlowLayoutPanel VoucherPanel { get; set; }
    }
}