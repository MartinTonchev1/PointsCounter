using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointsCounter.Forms
{
    public partial class MatchHistory : Form
    {
        public MatchHistory()
        {
            InitializeComponent();
            string folder = @"C:\Users\user\source\repos\PointsCounter";
            string fileName = "History.txt";
            string filePath = folder + @"\" + fileName;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    matchHistoryListBox.Items.Add(line);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitialMenu menu = new InitialMenu();
            menu.Show();
            this.Hide();
        }
    }
}
