namespace GameLogic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public struct CellLocation
    {
        private int m_Col;
        private int m_Row;

        public CellLocation(int i_Row, int i_Col)
        {
            m_Row = i_Row;
            m_Col = i_Col;
        }

        public int Row
        {
            get { return m_Row; }
            set { m_Row = value; }
        }

        public int Col
        {
            get { return m_Col; }
            set { m_Col = value; }
        }


    }
}
