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
    public partial class InGame : Form
    {
        Games game;
        Point labelLocation = new Point(400, 20);
        Point textBoxLocation = new Point(40, 25);
        Point pointsLabelLocation = new Point(200, 20);
        
        public InGame(Games game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void InGame_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < game.GamePlayers.Count; i++)
            {
                CreateLabel(i);
                CreateButtons(i);
                CreatePointsLabel(i);
            }
        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            game.GamePlayers = game.GamePlayers.OrderByDescending(x => x.PlayerPoints).ToList();
            game.EndDate = DateTime.Now;
            this.Hide();
            EndGame endGame = new EndGame(game, game.GamePlayers[0]);
            string folder = @"C:\Users\user\source\repos\PointsCounter";
            string fileName = "History.txt";
            string filePath = folder + @"\" + fileName;
            List<string> things = new List<string>
            {
                game.Name,
                game.Id.ToString(),
                game.StartDate.ToString(),
                game.EndDate.ToString(),
                game.GamePlayers[0].PlayerName
            };
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(String.Join(", ", things));
            }
            endGame.Show();
        }
        private void CreateLabel(int i)
        {
            Label label = new Label();
            label.Text = game.GamePlayers[i].PlayerName + "[" + game.GamePlayers[i].Id + "]";
            label.Font = new Font("Segoe UI", 16);
            label.Location = labelLocation;
            label.AutoSize = true;
            labelLocation.Y += 30;
            Controls.Add(label);
        }
        private void CreateTextBox()
        {
            TextBox textBox = new TextBox();
            textBox.Location = textBoxLocation;
            textBox.Size = new Size(25, 23);
            textBoxLocation.Y += 30;
            Controls.Add(textBox);
        }
        private void CreateButtons(int i)
        {
            Button minusButton = new Button
            {
                Text = "-",
                Tag = game.GamePlayers[i],
                Location = textBoxLocation,
            };
            minusButton.Click += MinusButton_Click;

            Button plusButton = new Button
            {
                Text = "+",
                Tag = game.GamePlayers[i],
                Location = new Point(textBoxLocation.X + 50, textBoxLocation.Y),
            };
            plusButton.Click += PlusButton_Click;
            textBoxLocation.Y += 20;
            Controls.Add(minusButton);
            Controls.Add(plusButton);
        }
        private void CreatePointsLabel(int i)
        {
            Label label = new Label
            {
                Text = game.GamePlayers[i].PlayerPoints.ToString(),
                Location = pointsLabelLocation,
                AutoSize = true,
                Tag = game.GamePlayers[i]
            };
            pointsLabelLocation.Y += 20;
            Controls.Add(label);
        }
        private void MinusButton_Click(object sender, EventArgs e)
        {
            GamePlayers player = (sender as Button)?.Tag as GamePlayers;
            if (player != null)
            {
                player.PlayerPoints--;
                UpdatePointsLabel(player);
            }
        }
        private void PlusButton_Click(object sender, EventArgs e)
        {
            GamePlayers player = (sender as Button)?.Tag as GamePlayers;
            if (player != null)
            {
                player.PlayerPoints++;
                UpdatePointsLabel(player);
            }
        }
        private void UpdatePointsLabel(GamePlayers player)
        {
            foreach (Control control in Controls)
            {
                if (control is Label label && label.Tag == player)
                {
                    label.Text = player.PlayerPoints.ToString();
                }
            }
        }
    }
}
