namespace GameUI
{
    partial class BoardGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardGameForm));
            this.ScoreOfPlayer1Lable = new System.Windows.Forms.Label();
            this.ScoreOfComputerOrPlayer2Lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScoreOfPlayer1Lable
            // 
            this.ScoreOfPlayer1Lable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ScoreOfPlayer1Lable.AutoSize = true;
            this.ScoreOfPlayer1Lable.Location = new System.Drawing.Point(46, 225);
            this.ScoreOfPlayer1Lable.Name = "ScoreOfPlayer1Lable";
            this.ScoreOfPlayer1Lable.Size = new System.Drawing.Size(81, 13);
            this.ScoreOfPlayer1Lable.TabIndex = 0;
            this.ScoreOfPlayer1Lable.Text = "ScoreOfPlayer1";
            // 
            // ScoreOfComputerOrPlayer2Lable
            // 
            this.ScoreOfComputerOrPlayer2Lable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ScoreOfComputerOrPlayer2Lable.AutoSize = true;
            this.ScoreOfComputerOrPlayer2Lable.Location = new System.Drawing.Point(165, 225);
            this.ScoreOfComputerOrPlayer2Lable.Name = "ScoreOfComputerOrPlayer2Lable";
            this.ScoreOfComputerOrPlayer2Lable.Size = new System.Drawing.Size(137, 13);
            this.ScoreOfComputerOrPlayer2Lable.TabIndex = 1;
            this.ScoreOfComputerOrPlayer2Lable.Text = "ScoreOfComputerOrPlayer2";
            // 
            // BoardGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ScoreOfComputerOrPlayer2Lable);
            this.Controls.Add(this.ScoreOfPlayer1Lable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BoardGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreOfPlayer1Lable;
        private System.Windows.Forms.Label ScoreOfComputerOrPlayer2Lable;
    }
}