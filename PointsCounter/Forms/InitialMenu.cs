﻿using System;
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
    public partial class InitialMenu : Form
    {
        
        public InitialMenu()
        {
            InitializeComponent();
        }

        private void InitialMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void createGame_Click(object sender, EventArgs e)
        {
            Games game1 = new Games();
            game1.Name = GameNameTextBox.Text;
            this.Hide();
            StartMenu form = new StartMenu(game1);
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void seeMatchHistory_Click(object sender, EventArgs e)
        {
            MatchHistory matchHistory = new MatchHistory();
            matchHistory.Show();
            this.Hide();
        }
    }
}
