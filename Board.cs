using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reversi_V2
{
    public class Board
    {
        const int Rows = 8;
        const int Cols = 8;
        public char[,] CreateBoard()
        {
            char[,] board = new char[Rows,Cols];
            for(int i = 0; i<Rows; i++)
            {
                for(int j= 0;j<Cols;j++)
                {
                    board[i,j] = ' ';
                }
                    board[3, 3] = 'b';
                    board[3, 4] = 'w';
                    board[4, 3] = 'w';
                    board[4, 4] = 'b';
            }

            return board;

        }
        public char[,] FillBoard(char[,] board)
        {
            CreateBoard();
            return board;
        }

        public void ShowBoard(char[,] board)
        {
            Console.Write(" ");
            for(int i=0;i<Rows;i++)
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

        public bool updateBoardBlack(int row, int col,char[,] board)
        {
            if(board[row,col] == ' ')
            {
                board[row,col] = 'b';
                Console.WriteLine("Black works");
                return true;

            }
            else
            {
                Console.WriteLine("Black error");
                Console.WriteLine("Invalid move");
                Thread.Sleep(5000);
                return false;
            }
        }

        public bool updateBoardWhite(int row, int col,char[,] board)
        {
            if(board[row,col] == ' ')
            {
                board[row,col] = 'w';
                Console.WriteLine("White works");
                return true;
            }
            else
            {
                Console.WriteLine("White error");
                Console.WriteLine("Invalid move");
                Thread.Sleep(5000);
                return false;
            }
        }

        public void ChangeBlack(int row, int col,char[,] board)
        {
            board[row, col] = 'b';
        }

        public void ChangeWhite(int row, int col,char[,] board)
        {
            board[row,col] = 'w';
        }

    }
}
