﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Views
{
    public interface IRecoveryView
    {
        string Email { get; set; }
        bool isSuccessful { get; set; }


        event EventHandler RecoverAccountEvent;


    }
}