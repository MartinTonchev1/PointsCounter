using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointsCounter.Classes;

namespace PointsCounter.Forms
{
    public partial class StartMenu : Form
    {
        private Games game;
        public StartMenu(Games game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            label1.Text = game.Name;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
