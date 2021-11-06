using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi_V2
{
    public class Board
    {
        const int Rows = 8;
        const int Cols = 8;
        char[,] board;

        public Board()
        {
            board = new char[Rows,Cols];
            for(int i = 0; i<Rows; i++)
            {
                for(int j= 0;j<Cols;j++)
                {
                    board[i,j] = ' ';
                }
            }
            board[3, 3] = 'w';
            board[3, 4] = 'b';
            board[4, 3] = 'b';
            board[4, 4] = 'w';
        }


        public void ShowBoard()
        {
            Console.Write(" ");
            for(int i=0;i<Cols;i++)
            {
                Console.Write(" " + i + " ");
            }
            Console.WriteLine();
            for(int i=0;i<Rows;i++)
            {
                Console.Write(i);
                for(int j= 0; j<Cols;j++)
                {
                    Console.Write("[" + board[i,j] + "]");
                }
                Console.WriteLine();
            }
        }
    }
}
