using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy.Views.UserControls
{
    public partial class MissionComponent : UserControl
    {

        public string Mission
        {
            get { return MissionName.Text; }
        }



        public string Points
        {
            get { return PointsLbl.Text; }
        }



        public MissionComponent(string mission, string point)
        {
            InitializeComponent();
            MissionName.Text = mission;
            PointsLbl.Text = $"{point} pts.";
            //this.Dock = DockStyle.Fill;
           

        }
    }
}
