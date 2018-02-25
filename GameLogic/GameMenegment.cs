using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameLogic
{
    public class GameMenegment
    {
        private Board m_GameBoard;
        private CellLocation m_LastMove;
        private Player m_Player1, m_Player2, m_LastPlayer;
        private StringBuilder m_WinnerAndScroeInfo = new StringBuilder();
        private int m_MoveCounter = 0;
        private string m_ComputerName = "Computer";
        private Random m_Random = new Random();
        private bool m_IsWin = false;

        public GameMenegment(int i_NumOfRows, int i_NumOfCols)
        {
            m_Player1 = new Player('X');
            m_Player2 = new Player('O');
            m_GameBoard = new Board(i_NumOfRows, i_NumOfCols);
        }

        public int BoardLenght
        {
            get { return m_GameBoard.BoardLength; }
        }

        public int BoardWidth
        {
            get { return m_GameBoard.BoardWidth; }
        }

        public Player Player1
        {
            get { return m_Player1; }
        }

        public Player Player2
        {
            get { return m_Player2; }
        }

        public string WinnerMsg
        {
            get { return m_WinnerAndScroeInfo.ToString(); }
        }

        public string ComputerPlayerName
        {
            get { return m_ComputerName; }
        }

        public bool IsWin
        {
            get { return m_IsWin; }
        }

        public void NewGame(int i_BoardLength)
        {
            m_WinnerAndScroeInfo = new StringBuilder();
            m_MoveCounter = 0;
            CreateBoardGame(i_BoardLength);
        }

        public void CreateBoardGame(int i_BoardLength)
        {
            m_GameBoard = new Board(i_BoardLength, i_BoardLength);
        }

        public void CellChange(int i_Lenght, int i_Width, Player i_LastPlayerPlaying)
        {
            m_GameBoard.SetCellOnBoard(i_Lenght, i_Width, i_LastPlayerPlaying.Type);
            m_LastMove.Row = i_Lenght;
            m_LastMove.Col = i_Width;
            m_LastPlayer = i_LastPlayerPlaying;
            m_MoveCounter++;
        }

        public bool IsAvailableOnBoardGame(int i_Boardlenght, int i_BoardWidh)
        {
            return !m_GameBoard.BoardGame[i_Boardlenght, i_BoardWidh].IsCellIsFree;
        }

        public bool IsGameOver()
        {
            bool isGameOver = m_GameBoard.IsRowCheck(m_LastMove.Row) || m_GameBoard.IsColCheck(m_LastMove.Col);
            int center = m_GameBoard.BoardLength / 2;

            if (m_LastMove.Col == m_LastMove.Row || m_LastMove.Col + m_LastMove.Row == BoardLenght - 1)
            {
                if (BoardLenght % 2 == 1)
                {
                    if (((m_LastMove.Row > center) && (m_LastMove.Col < center)) || ((m_LastMove.Row < center) && (m_LastMove.Col > center)))
                    {
                        isGameOver = isGameOver || m_GameBoard.IsRightToLeftDiagonal();
                    }
                    else if (((m_LastMove.Row > center) && (m_LastMove.Col > center)) || ((m_LastMove.Row < center) && (m_LastMove.Col < center)))
                    {
                        isGameOver = isGameOver || m_GameBoard.IsLeftToRightDiagonal();
                    }
                    else if ((m_LastMove.Row == center) && (m_LastMove.Col == center))
                    {
                        isGameOver = isGameOver || m_GameBoard.IsLeftToRightDiagonal() || m_GameBoard.IsRightToLeftDiagonal();
                    }
                }
                else
                {
                    if (((m_LastMove.Row >= center) && (m_LastMove.Col < center)) || ((m_LastMove.Row < center) && (m_LastMove.Col >= center)))
                    {
                        isGameOver = isGameOver || m_GameBoard.IsRightToLeftDiagonal();
                    }
                    else if (((m_LastMove.Row >= center) && (m_LastMove.Col >= center)) || ((m_LastMove.Row < center) && (m_LastMove.Col < center)))
                    {
                        isGameOver = isGameOver || m_GameBoard.IsLeftToRightDiagonal();
                    }
                }
            }

            if (isGameOver)
            {
                if (m_LastPlayer == m_Player1)
                {
                    m_Player2.ChangeScore();
                    m_WinnerAndScroeInfo.AppendFormat("The Winner is: {0} {1}", m_Player2.Name, Environment.NewLine);
                }
                else
                {
                    m_Player1.ChangeScore();
                    m_WinnerAndScroeInfo.AppendFormat("The Winner is: {0} {1}", m_Player1.Name, Environment.NewLine);
                }

                m_IsWin = true;
            }
            else
            {
                if (m_MoveCounter == m_GameBoard.BoardLength * m_GameBoard.BoardWidth)
                {
                    isGameOver = true;
                    m_WinnerAndScroeInfo.AppendFormat("Tie! {0}", Environment.NewLine);
                    m_IsWin = false;
                }
            }

            return isGameOver;
        }

        public void InitFirstPlayer(string i_PlayerName)
        {
            m_Player1.Name = i_PlayerName;
        }

        public void InitSecondPlayer(string i_PlayerName)
        {
            m_Player2.Name = i_PlayerName;
        }

        public Point ComputerMove()
        {
            m_Random = new Random();
            int row, column;

            do
            {
                row = m_Random.Next(0, BoardLenght);
                column = m_Random.Next(0, BoardWidth);
            }
            while (!IsAvailableOnBoardGame(row, column));

            CellChange(row, column, m_Player2);

            return new Point(row, column);
        }
    }
}
