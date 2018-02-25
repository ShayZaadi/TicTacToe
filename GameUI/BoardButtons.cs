namespace GameUI
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;

    public class BoardButtons : Button
    {
        private int m_X;
        private int m_Y;

        public BoardButtons(int i_X, int i_Y)
        {
            m_X = i_X;
            m_Y = i_Y;
        }

        public int X
        {
            get { return m_X; }
        }

        public int Y
        {
            get { return m_Y; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BoardButtons
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);

        }
    }
}
