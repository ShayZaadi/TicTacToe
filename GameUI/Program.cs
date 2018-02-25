using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameUI.UI
{
    static class Program
    {
        static void Main()
        {
            BoardGameForm newBoardGame = new BoardGameForm();
            newBoardGame.ShowDialog();
        }
    }
}
