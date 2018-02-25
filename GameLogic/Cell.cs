namespace GameLogic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public struct Cell
    {
        private char m_Value;
        private bool m_IsCellIsFree;

        public char ValueOfCell
        {
            get { return m_Value; }
            set { m_Value = value; }
        }

        public bool IsCellIsFree
        {
            get { return m_IsCellIsFree; }
            set { m_IsCellIsFree = value; }
        }
    }
}
