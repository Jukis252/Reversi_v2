using System;

namespace Reversi_V2
{
    internal class ReverseElement
    {
        public readonly Board Board = new Board();

        public void ReverseBlack(int row, int col,char [,] boardB)
        {
            if(row > 2)
            {
                if(boardB[row-2,col] == 'b')
                {
                    Board.ChangeBlack(row-1,col,boardB);
                    Console.WriteLine("row-1");
                }
            }
            if(row>8)
            {
                if(boardB[row+2,col] == 'b')
                {
                    Board.ChangeBlack(row+1,col,boardB);
                    Console.WriteLine("row+1");
                }
            }
            if(col>2)
            {
                if(boardB[row,col-2] == 'b' )
                {
                    Board.ChangeBlack(row,col-1,boardB);
                    Console.WriteLine("col-1");
                }
            }
            if(col>8)
            {
                if(boardB[row,col+2] == 'b' )
                {
                    Board.ChangeBlack(row,col+1,boardB);
                    Console.WriteLine("col+1");
                }
            }

        }

        public void ReverseBlack(int row, int col,char [,] boardB,int turn)
        {
            if(row > 2)
            {
                if(boardB[row-2,col] == 'b')
                {
                    Board.ChangeBlack(row-1,col,boardB,turn);
                    Console.WriteLine("row-1");
                }
            }
            if(row>6)
            {
                if(boardB[row+2,col] == 'b')
                {
                    Board.ChangeBlack(row+1,col,boardB,turn);
                    Console.WriteLine("row+1");
                }
            }
            if(col>2)
            {
                if(boardB[row,col-2] == 'b' )
                {
                    Board.ChangeBlack(row,col-1,boardB,turn);
                    Console.WriteLine("col-1");
                }
            }
            if(col>6)
            {
                if(boardB[row,col+2] == 'b' )
                {
                    Board.ChangeBlack(row,col+1,boardB,turn);
                    Console.WriteLine("col+1");
                }
            }

        }

        public void ReverseWhite(int row, int col,char [,] boardW)
        {
            if(row > 2)
            {
                if(boardW[row-2,col] == 'w')
                {
                    Board.ChangeWhite(row-1,col,boardW);
                    Console.WriteLine("row-1");
                }
            }
            if(row>8)
            {
                if(boardW[row+2,col] == 'w')
                {
                    Board.ChangeWhite(row+1,col,boardW);
                    Console.WriteLine("row+1");
                }
            }
            if(col>2)
            {
                if(boardW[row,col-2] == 'w')
                {
                    Board.ChangeWhite(row,col-1,boardW);
                    Console.WriteLine("col-1");
                }
            }
            if(col>8)
            {
                if(boardW[row,col+2] == 'w')
                {
                    Board.ChangeWhite(row,col+1,boardW);
                    Console.WriteLine("col+1");
                }
            }

        }

        public void ReverseWhite(int row, int col,char [,] boardW, int turn)
        {
            if(row > 2)
            {
                if(boardW[row-2,col] == 'w')
                {
                    Board.ChangeWhite(row-1,col,boardW,turn);
                    Console.WriteLine("row-1");
                }
            }
            if(row>6)
            {
                if(boardW[row+2,col] == 'w')
                {
                    Board.ChangeWhite(row+1,col,boardW,turn);
                    Console.WriteLine("row+1");
                }
            }
            if(col>2)
            {
                if(boardW[row,col-2] == 'w')
                {
                    Board.ChangeWhite(row,col-1,boardW,turn);
                    Console.WriteLine("col-1");
                }
            }
            if(col>6)
            {
                if(boardW[row,col+2] == 'w')
                {
                    Board.ChangeWhite(row,col+1,boardW,turn);
                    Console.WriteLine("col+1");
                }
            }

        }
    }
}