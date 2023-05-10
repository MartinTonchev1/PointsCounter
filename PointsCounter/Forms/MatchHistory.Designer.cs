namespace PointsCounter.Forms
{
    partial class MatchHistory
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
            this.matchHistoryListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matchHistoryListBox
            // 
            this.matchHistoryListBox.FormattingEnabled = true;
            this.matchHistoryListBox.ItemHeight = 15;
            this.matchHistoryListBox.Location = new System.Drawing.Point(0, 0);
            this.matchHistoryListBox.Name = "matchHistoryListBox";
            this.matchHistoryListBox.Size = new System.Drawing.Size(567, 454);
            this.matchHistoryListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return to main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MatchHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matchHistoryListBox);
            this.Name = "MatchHistory";
            this.Text = "MatchHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox matchHistoryListBox;
        private Button button1;
    }
}