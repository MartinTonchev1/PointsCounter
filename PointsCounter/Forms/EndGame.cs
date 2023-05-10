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
    public partial class EndGame : Form
    {
        private Games game;
        private GamePlayers winner;
        public EndGame(Games game, GamePlayers winner)
        {
            InitializeComponent();
            this.game = game;
            this.winner = winner;

            gameNameLabel.Text = game.Name;
            nameLabel.Text = winner.PlayerName;
            idLabel.Text = winner.Id.ToString();
            pointsLabel.Text = winner.PlayerPoints.ToString();
            startDateLabel.Text = game.StartDate.ToString();
            endDateLabel.Text = game.EndDate.ToString();
        }

        private void EndGame_Load(object sender, EventArgs e)
        {

        }

        private void returnToMainMenu_Click(object sender, EventArgs e)
        {
            InitialMenu menu = new InitialMenu();
            menu.Show();
            this.Hide();
        }
    }
}
