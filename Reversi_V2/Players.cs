using System;

namespace Reversi_V2
{
    internal abstract class Players : Board
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
