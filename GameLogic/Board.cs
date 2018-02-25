using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    public class Board
    {
        private readonly int r_BoardLength;
        private readonly int r_BoardWidth;
        private readonly Cell[,] m_boardGame;
        private int m_BoardSize;

        public Board(int i_BoardLenght, int i_BoardWidth)
        {
            r_BoardLength = i_BoardLenght;
            r_BoardWidth = i_BoardWidth;
            m_BoardSize = i_BoardLenght * i_BoardWidth;
            m_boardGame = new Cell[r_BoardLength, r_BoardWidth];
        }

        public int BoardLength
        {
            get { return r_BoardLength; }
        }

        public int BoardWidth
        {
            get { return r_BoardWidth; }
        }

        public Cell[,] BoardGame
        {
            get { return m_boardGame; }
        }

        public int BoardSize
        {
            get { return m_BoardSize; }
        }

        public void SetCellOnBoard(int i_Length, int i_Width, char i_Value)
        {
            m_boardGame[i_Length, i_Width].ValueOfCell = i_Value;
            m_boardGame[i_Length, i_Width].IsCellIsFree = true;
        }

        public bool IsRowCheck(int i_Row)
        {
            bool isRow = true;
            for (int i = 0; i < r_BoardWidth - 1; i++)
            {
                if (m_boardGame[i_Row, i].ValueOfCell != m_boardGame[i_Row, i + 1].ValueOfCell)
                {
                    isRow = false;
                    break;
                }
            }

            return isRow;
        }

        public bool IsColCheck(int i_column)
        {
            bool isCol = true;

            for (int i = 0; i < r_BoardLength - 1; i++)
            {
                if (m_boardGame[i, i_column].ValueOfCell != m_boardGame[i + 1, i_column].ValueOfCell)
                {
                    isCol = false;
                    break;
                }
            }

            return isCol;
        }

        public bool IsLeftToRightDiagonal()
        {
            bool isDiagonal = true;

            for (int i = 0; i < r_BoardLength - 1; i++)
            {
                if (m_boardGame[i, i].ValueOfCell != m_boardGame[i + 1, i + 1].ValueOfCell)
                {
                    isDiagonal = false;
                    break;
                }
            }

            return isDiagonal;
        }

        public bool IsRightToLeftDiagonal()
        {
            bool isDiagonal = true;
            int j = 0;

            for (int i = r_BoardLength - 1; i > 0; i--)
            {
                if (m_boardGame[i, j].ValueOfCell != m_boardGame[i - 1, j + 1].ValueOfCell)
                {
                    isDiagonal = false;
                    break;
                }

                j++;
            }

            return isDiagonal;
        }
    }
}
