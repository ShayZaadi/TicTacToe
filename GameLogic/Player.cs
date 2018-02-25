using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    public class Player
    {
        private readonly char r_Type;
        private string m_Name;
        private int m_Score;

        public Player(char i_Type)
        {
            r_Type = i_Type;
            m_Score = 0;
            m_Name = "Player";
        }

        public char Type
        {
            get { return r_Type; }
        }

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public int Score
        {
            get { return m_Score; }
        }

        public void ChangeScore()
        {
            m_Score = m_Score + 1;
        }
    }
}
