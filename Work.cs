using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi_V2
{
    class Work
    {
        Players players = new Players();
        Board board = new Board();
        int row=0;
        int col=0;
        public void Start()
        {
            char [,] newBoard = board.CreateBoard();
            int run = 1;
            while(run<60)
            {
                Console.Clear();
                board.ShowBoard(newBoard);
                if(run%2 == 0)
                {
                    var dataW = players.WhitePlayer(row,col);
                    if(board.updateBoardWhite(dataW.Item1 ,dataW.Item2,newBoard) == true)
                    {
                        ReverseWhite(dataW.Item1,dataW.Item2,newBoard);
                        run++;
                    }
                }
                else if(run%2 != 0)
                {
                    var dataB = players.BlackPlayer(row,col);
                    if(board.updateBoardBlack(dataB.Item1 ,dataB.Item2 ,newBoard) == true)
                    {
                        ReverseBlack(dataB.Item1,dataB.Item2,newBoard);
                        run++;
                    }
                }
                else
                {
                    Console.WriteLine("Unexpected error");
                }

            }
        }

        public void ReverseBlack(int row, int col,char [,] boardB)
        {
            if(row > 2)
            {
                if(boardB[row-2,col] == 'b')
                {
                    board.ChangeBlack(row-1,col,boardB);
                    Console.WriteLine("row-1");
                }
            }
            if(row>8)
            {
                if(boardB[row+2,col] == 'b')
                {
                    board.ChangeBlack(row+1,col,boardB);
                    Console.WriteLine("row+1");
                }
            }
            if(col>2)
            {
                if(boardB[row,col-2] == 'b' )
                {
                    board.ChangeBlack(row,col-1,boardB);
                    Console.WriteLine("col-1");
                }
            }
            if(col>8)
            {
                if(boardB[row,col+2] == 'b' )
                {
                    board.ChangeBlack(row,col+1,boardB);
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
                    board.ChangeWhite(row-1,col,boardW);
                    Console.WriteLine("row-1");
                }
            }
            if(row>8)
            {
                if(boardW[row+2,col] == 'w')
                {
                    board.ChangeWhite(row+1,col,boardW);
                    Console.WriteLine("row+1");
                }
            }
            if(col>2)
            {
                if(boardW[row,col-2] == 'w')
                {
                    board.ChangeWhite(row,col-1,boardW);
                    Console.WriteLine("col-1");
                }
            }
            if(col>8)
            {
                if(boardW[row,col+2] == 'w')
                {
                    board.ChangeWhite(row,col+1,boardW);
                    Console.WriteLine("col+1");
                }
            }

        }
    }
}
