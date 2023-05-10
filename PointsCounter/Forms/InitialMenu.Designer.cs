namespace PointsCounter.Forms
{
    partial class InitialMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createGame = new System.Windows.Forms.Button();
            this.GameNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.seeMatchHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createGame
            // 
            this.createGame.Location = new System.Drawing.Point(345, 367);
            this.createGame.Name = "createGame";
            this.createGame.Size = new System.Drawing.Size(106, 45);
            this.createGame.TabIndex = 0;
            this.createGame.Text = "Create Game";
            this.createGame.UseVisualStyleBackColor = true;
            this.createGame.Click += new System.EventHandler(this.createGame_Click);
            // 
            // GameNameTextBox
            // 
            this.GameNameTextBox.Location = new System.Drawing.Point(148, 51);
            this.GameNameTextBox.Name = "GameNameTextBox";
            this.GameNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.GameNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of the game:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // seeMatchHistory
            // 
            this.seeMatchHistory.Location = new System.Drawing.Point(345, 294);
            this.seeMatchHistory.Name = "seeMatchHistory";
            this.seeMatchHistory.Size = new System.Drawing.Size(106, 43);
            this.seeMatchHistory.TabIndex = 3;
            this.seeMatchHistory.Text = "Match history";
            this.seeMatchHistory.UseVisualStyleBackColor = true;
            this.seeMatchHistory.Click += new System.EventHandler(this.seeMatchHistory_Click);
            // 
            // InitialMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seeMatchHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameNameTextBox);
            this.Controls.Add(this.createGame);
            this.Name = "InitialMenu";
            this.Text = "InitialMenu";
            this.Load += new System.EventHandler(this.InitialMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createGame;
        private TextBox GameNameTextBox;
        private Label label1;
        private Button seeMatchHistory;
    }
}