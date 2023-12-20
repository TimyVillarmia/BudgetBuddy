using BudgetBuddy.Models;
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
    public partial class QuestComponent : UserControl
    {

        public string Mission
        {
            get { return MissionName.Text; }
        }



        public string Points
        {
            get { return PointsLbl.Text; }
        }

        private string _quest_description;
        private int _quest_reward;
        private DateTime _quest_date;
        private string _status;





        public QuestComponent(string quest_description, int quest_reward, DateTime quest_date, string status)
        {
            InitializeComponent();

            _quest_description = quest_description;
            _quest_reward = quest_reward;
            _quest_date = quest_date;
            _status = status;

            MissionName.Text = _quest_description;
            PointsLbl.Text = $"{_quest_reward} pts.";

            if (_status == "Complete")
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
           

        }

        public QuestComponent(string quest_description, int quest_reward, DateTime quest_date)
        {
            InitializeComponent();

            _quest_description = quest_description;
            _quest_reward = quest_reward;
            _quest_date = quest_date;

            MissionName.Text = _quest_description;
            PointsLbl.Text = $"{_quest_reward} pts.";

            if (_status == "Complete")
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }


        }
    }
}
