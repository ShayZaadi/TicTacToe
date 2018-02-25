namespace GameUI
{
    partial class GameSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSettingsForm));
            this.PlayersLabel = new System.Windows.Forms.Label();
            this.Player1Label = new System.Windows.Forms.Label();
            this.BoardSizeLabel = new System.Windows.Forms.Label();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.ColsLabel = new System.Windows.Forms.Label();
            this.isComputerOrPlayer = new System.Windows.Forms.CheckBox();
            this.Player1 = new System.Windows.Forms.TextBox();
            this.ComputerOrPlayer2 = new System.Windows.Forms.TextBox();
            this.NumericRows = new System.Windows.Forms.NumericUpDown();
            this.NumericCols = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCols)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.AutoSize = true;
            this.PlayersLabel.Location = new System.Drawing.Point(22, 9);
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(44, 13);
            this.PlayersLabel.TabIndex = 0;
            this.PlayersLabel.Text = "Players:";
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(23, 34);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(45, 13);
            this.Player1Label.TabIndex = 10;
            this.Player1Label.Text = "Player1:";
            // 
            // BoardSizeLabel
            // 
            this.BoardSizeLabel.AutoSize = true;
            this.BoardSizeLabel.Location = new System.Drawing.Point(22, 99);
            this.BoardSizeLabel.Name = "BoardSizeLabel";
            this.BoardSizeLabel.Size = new System.Drawing.Size(61, 13);
            this.BoardSizeLabel.TabIndex = 50;
            this.BoardSizeLabel.Text = "Board Size:";
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(42, 127);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(37, 13);
            this.RowsLabel.TabIndex = 60;
            this.RowsLabel.Text = "Rows:";
            // 
            // ColsLabel
            // 
            this.ColsLabel.AutoSize = true;
            this.ColsLabel.Location = new System.Drawing.Point(136, 127);
            this.ColsLabel.Name = "ColsLabel";
            this.ColsLabel.Size = new System.Drawing.Size(30, 13);
            this.ColsLabel.TabIndex = 80;
            this.ColsLabel.Text = "Cols:";
            // 
            // isComputerOrPlayer
            // 
            this.isComputerOrPlayer.AutoSize = true;
            this.isComputerOrPlayer.Location = new System.Drawing.Point(26, 63);
            this.isComputerOrPlayer.Name = "isComputerOrPlayer";
            this.isComputerOrPlayer.Size = new System.Drawing.Size(64, 17);
            this.isComputerOrPlayer.TabIndex = 30;
            this.isComputerOrPlayer.Text = "Player2:";
            this.isComputerOrPlayer.UseVisualStyleBackColor = true;
            this.isComputerOrPlayer.CheckedChanged += new System.EventHandler(this.isComputerOrPlayer_CheckedChanged);
            // 
            // Player1
            // 
            this.Player1.Location = new System.Drawing.Point(97, 31);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(100, 20);
            this.Player1.TabIndex = 20;
            this.Player1.Text = "Enter Name";
            // 
            // ComputerOrPlayer2
            // 
            this.ComputerOrPlayer2.Enabled = false;
            this.ComputerOrPlayer2.Location = new System.Drawing.Point(96, 61);
            this.ComputerOrPlayer2.Name = "ComputerOrPlayer2";
            this.ComputerOrPlayer2.Size = new System.Drawing.Size(100, 20);
            this.ComputerOrPlayer2.TabIndex = 40;
            this.ComputerOrPlayer2.Text = "[Computer]";
            // 
            // NumericRows
            // 
            this.NumericRows.Location = new System.Drawing.Point(85, 125);
            this.NumericRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumericRows.Name = "NumericRows";
            this.NumericRows.Size = new System.Drawing.Size(34, 20);
            this.NumericRows.TabIndex = 70;
            this.NumericRows.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericRows.ValueChanged += new System.EventHandler(this.NumericRowsCols_ValueChanged);
            // 
            // NumericCols
            // 
            this.NumericCols.Location = new System.Drawing.Point(172, 125);
            this.NumericCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericCols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumericCols.Name = "NumericCols";
            this.NumericCols.Size = new System.Drawing.Size(34, 20);
            this.NumericCols.TabIndex = 90;
            this.NumericCols.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericCols.ValueChanged += new System.EventHandler(this.NumericRowsCols_ValueChanged);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.Control;
            this.StartButton.Location = new System.Drawing.Point(26, 167);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(180, 23);
            this.StartButton.TabIndex = 100;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(224, 197);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.NumericCols);
            this.Controls.Add(this.NumericRows);
            this.Controls.Add(this.ComputerOrPlayer2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.isComputerOrPlayer);
            this.Controls.Add(this.ColsLabel);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.BoardSizeLabel);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.PlayersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.NumericRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

