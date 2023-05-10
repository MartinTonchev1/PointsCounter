namespace PointsCounter.Forms
{
    partial class InGame
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
            this.endGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // endGameButton
            // 
            this.endGameButton.Location = new System.Drawing.Point(368, 396);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(75, 23);
            this.endGameButton.TabIndex = 0;
            this.endGameButton.Text = "End game";
            this.endGameButton.UseVisualStyleBackColor = true;
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click);
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endGameButton);
            this.Name = "InGame";
            this.Text = "InGame";
            this.Load += new System.EventHandler(this.InGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button endGameButton;
    }
}