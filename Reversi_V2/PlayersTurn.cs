using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi_V2
{
    internal class PlayersTurn: Players
    {
        public void MakeTurnWhite(int row,int col)
        {
            WhitePlayer(row, col);
        }

        public void MakeTurnBlack(int row,int col)
        {
            BlackPlayer(row, col);
        }

    }
}
