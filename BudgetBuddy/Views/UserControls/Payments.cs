using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BudgetBuddy.Views.UserControls
{
    public partial class Payments : UserControl
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            ShopNameCombo.SelectedIndex = 0;
        }

        private void ShopNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] shop = { "Figma Pro Plan", "Youtube Premium", "Spotify Premium", "Netflix" };

            switch (ShopNameCombo.SelectedIndex)
            {
                case 0:
                    Picturebox.Image = Properties.Resources.Figma;
                    NameShop.Text = shop[0];
                    break;
                case 1:
                    Picturebox.Image = Properties.Resources.Youtube;
                    NameShop.Text = shop[1];
                    break;
                case 2:
                    Picturebox.Image = Properties.Resources.Spotify;
                    NameShop.Text = shop[2];
                    break;
                case 3:
                    Picturebox.Image = Properties.Resources.Netflix;
                    NameShop.Text = shop[3];
                    break;
            }

        }


    }
}
