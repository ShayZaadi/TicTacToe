using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameUI
{
    public partial class GameSettingsForm : Form
    {
        private Label PlayersLabel;
        private Label Player1Label;
        private Label BoardSizeLabel;
        private Label RowsLabel;
        private Label ColsLabel;
        private TextBox Player1;
        private TextBox ComputerOrPlayer2;
        private CheckBox isComputerOrPlayer;
        private NumericUpDown NumericRows;
        private NumericUpDown NumericCols;
        private Button StartButton;

        private bool m_IsSecondPlayer = false;
        private string m_Player1Name;
        private string m_ComputerOrPlayer2Name = "Computer";
        private int m_numberOfRows;
        private int m_numberOfCols;

        public GameSettingsForm()
        {
            InitializeComponent();
        }

        public string Player1Name
        {
            get { return m_Player1Name; }
        }

        public string ComputerOrPlayer2Name
        {
            get { return m_ComputerOrPlayer2Name; }
        }

        public bool IsSecondPlayer
        {
            get { return m_IsSecondPlayer; }
        }

        public int Rows
        {
            get { return m_numberOfRows; }
        }

        public int Cols
        {
            get { return m_numberOfCols; }
        }

        private void isComputerOrPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                ComputerOrPlayer2.Enabled = true;
                ComputerOrPlayer2.Text = "Enter Name";
                m_IsSecondPlayer = true;
            }
            else
            {
                ComputerOrPlayer2.Enabled = false;
                ComputerOrPlayer2.Text = "[Computer]";
                m_IsSecondPlayer = false;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Player1.Text != "Enter Name" && (ComputerOrPlayer2.Text != "Enter Name"))
            {
                m_Player1Name = Player1.Text;
                if (ComputerOrPlayer2.Text == "[Computer]")
                {
                    m_ComputerOrPlayer2Name = "Computer";
                }
                else
                {
                    m_ComputerOrPlayer2Name = ComputerOrPlayer2.Text;
                }
                m_numberOfRows = (int)NumericRows.Value;
                m_numberOfCols = (int)NumericCols.Value;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Enter name please");
            }
        }

        private void NumericRowsCols_ValueChanged(object sender, EventArgs e)
        {
            if ((sender as NumericUpDown) == NumericRows)
            {
                NumericCols.Value = NumericRows.Value;
            }
            else
            {
                NumericRows.Value = NumericCols.Value;
            }
        }

        

    }
}
