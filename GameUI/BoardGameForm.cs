using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GameLogic;

namespace GameUI
{
    public partial class BoardGameForm : Form
    {
        private readonly int r_ButtonsSpaces = 10;
        private readonly BoardButtons[,] r_ButtonsArray;
        private readonly int r_RowsNumber;
        private readonly int r_ColsNumber;
        private GameSettingsForm m_GameSettings;
        private GameMenegment m_GameMenegment;
        private Player m_CurrentPlayer;
        private bool m_isPlayingAgainstComp;

        public BoardGameForm()
        {
            InitializeComponent();

            m_GameSettings = new GameSettingsForm();
            if (m_GameSettings.ShowDialog() != DialogResult.Cancel)
            {
                r_RowsNumber = m_GameSettings.Rows;
                r_ColsNumber = m_GameSettings.Cols;
                r_ButtonsArray = new BoardButtons[r_RowsNumber, r_ColsNumber];
                startTheGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void startTheGame()
        {
            m_GameMenegment = new GameMenegment(r_RowsNumber, r_ColsNumber);
            buildBoardGame();
            m_CurrentPlayer = m_GameMenegment.Player1;
            m_isPlayingAgainstComp = !m_GameSettings.IsSecondPlayer;
        }

        private void newGame()
        {
            foreach (BoardButtons currentButton in r_ButtonsArray)
            {
                currentButton.Enabled = true;
                currentButton.Text = string.Empty;
            }

            setScore();
            m_GameMenegment.NewGame(r_ColsNumber);
        }

        private void buildBoardGame()
        {
            int x = r_ButtonsSpaces;
            int y = r_ButtonsSpaces;
            int width = 75;
            int hight = 60;

            for (int i = 0; i < r_RowsNumber; i++)
            {
                for (int j = 0; j < r_ColsNumber; j++)
                {
                    BoardButtons newButton = new BoardButtons(i, j);
                    r_ButtonsArray[i, j] = newButton;
                    newButton.Size = new Size(width, hight);
                    newButton.Location = new Point(x, y);
                    newButton.Click += new EventHandler(this.boardButton_click);
                    this.Controls.Add(newButton);
                    x += width + r_ButtonsSpaces;
                }

                y += hight + r_ButtonsSpaces;
                x = r_ButtonsSpaces;
            }

            this.Size = new Size(this.Size.Width, this.Size.Height + hight);

            m_GameMenegment.InitFirstPlayer(m_GameSettings.Player1Name);
            m_GameMenegment.InitSecondPlayer(m_GameSettings.ComputerOrPlayer2Name);
            m_CurrentPlayer = m_GameMenegment.Player1;
            setScore();
        }

        private void setScore()
        {
            ScoreOfPlayer1Lable.Text = string.Format("{0} : {1}", m_GameMenegment.Player1.Name, m_GameMenegment.Player1.Score);
            ScoreOfComputerOrPlayer2Lable.Text = string.Format("{0} : {1}", m_GameMenegment.Player2.Name, m_GameMenegment.Player2.Score);
        }

        private void boardButton_click(object sender, EventArgs e)
        {
            BoardButtons currentButton = sender as BoardButtons;
            currentButton.Text = m_CurrentPlayer.Type.ToString();
            currentButton.Enabled = false;
            m_GameMenegment.CellChange(currentButton.X, currentButton.Y, m_CurrentPlayer);

            if (!endOrNewTurn())
            {
                if (m_isPlayingAgainstComp)
                {
                    computerTurn();
                }
            }
        }

        private bool endOrNewTurn()
        {
            bool isEndTheGame;

            if (isEndTheGame = m_GameMenegment.IsGameOver())
            {
                string playerWinOrTie;
                string show = string.Format("{0} Would you like to play another round?", m_GameMenegment.WinnerMsg);

                if (m_GameMenegment.IsWin)
                {
                    playerWinOrTie = "Win!";
                }
                else
                {
                    playerWinOrTie = "Tie!";
                }

                DialogResult isAnotherGame = MessageBox.Show(show, playerWinOrTie, MessageBoxButtons.YesNo);
                if (isAnotherGame == DialogResult.Yes)
                {
                    m_GameMenegment.InitFirstPlayer(m_GameSettings.Player1Name);
                    m_GameMenegment.InitSecondPlayer(m_GameSettings.ComputerOrPlayer2Name);
                    m_CurrentPlayer = m_GameMenegment.Player1;
                    newGame();
                }
                else
                {
                    MessageBox.Show("Thank you for playing!");
                    Application.Exit();
                }
            }
            else
            {
                changeTurn();
            }

            return isEndTheGame;
        }

        private void changeTurn()
        {
            if (m_CurrentPlayer == m_GameMenegment.Player1)
            {
                m_CurrentPlayer = m_GameMenegment.Player2;
            }
            else
            {
                m_CurrentPlayer = m_GameMenegment.Player1;
            }
        }

        private void computerTurn()
        {
            Point locationOfCell = m_GameMenegment.ComputerMove();
            BoardButtons changeThebutton = r_ButtonsArray[locationOfCell.X, locationOfCell.Y];
            changeThebutton.Enabled = false;
            changeThebutton.Text = m_CurrentPlayer.Type.ToString();
            endOrNewTurn();
        }
    }
}
