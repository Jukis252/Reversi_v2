using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi_V2
{
    public class Players
    {
        int row =0;
        int col = 0;
        public void WhitePlayer(int row, int col)
        {
            Console.WriteLine("Input row: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input column: ");
            col = Convert.ToInt32(Console.ReadLine());
            
        }
        public void BlackPlayer(int row, int col)
        {
            Console.WriteLine("Input row: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input column: ");
            col = Convert.ToInt32(Console.ReadLine());
        }
    }
}
