using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi_V2
{
    public class Players
    {
        public (int,int) WhitePlayer(int row, int col)
        {
            Console.WriteLine("White players turn");
            Console.WriteLine("Input row: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input column: ");
            col = Convert.ToInt32(Console.ReadLine());
            return (row, col);
            
        }
        public (int,int) BlackPlayer(int row, int col)
        {
            Console.WriteLine("Black players turn");
            Console.WriteLine("Input row: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input column: ");
            col = Convert.ToInt32(Console.ReadLine());
            return (row, col);
        }
    }
}
