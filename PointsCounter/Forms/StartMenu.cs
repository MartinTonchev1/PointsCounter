using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointsCounter.Models;

namespace PointsCounter.Forms
{
    public partial class StartMenu : Form
    {
        private Games game;
        private int i = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            Random random = new Random();
            game.GamePlayers.Add(new GamePlayers(random.Next(1000, 9999), game.Id, textBox1.Text, 0));
            gamePlayersList.Text = gamePlayersList.Text + "\n" + game.GamePlayers[i].PlayerName + "[" + game.GamePlayers[i].Id + "]";
            i++;
            textBox1.Text = "";
        }

        private void gamePlayersList_Click(object sender, EventArgs e)
        {

        }

        private void startGame_Click(object sender, EventArgs e)
        {
            InGame inGame = new InGame(game);
            game.StartDate = DateTime.Now;
            this.Hide();
            inGame.Show();
        }
    }
}
