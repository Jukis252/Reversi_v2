using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi_V2
{
    public class Work
    {
        Board board = new Board();
        public Work()
        {
            int run = 1;
            while(60<run)
            {
                Console.Clear();
                board.ShowBoard();
                Console.WriteLine("");
            }
        }
    }
}
