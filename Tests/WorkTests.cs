using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reversi_V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiTests
{
    [TestClass]
    public class WorkTests
    {
        Players players = new Players();
        Board board = new Board();
        int row=0;
        int col=0;

        [TestMethod]
        public void StartTest()
        {
            char [,] newBoard = board.CreateBoard();
            int run = 1;
            while(run<60)
            {
                
                board.ShowBoard(newBoard);
                if(run%2 == 0)
                {
                    var dataW = players.WhitePlayer(row,col);
                    if(board.updateBoardWhite(dataW.Item1 ,dataW.Item2,newBoard) == true)
                    {
                        ReverseWhiteTest();
                        run++;
                    }
                }
                else if(run%2 != 0)
                {
                    var dataB = players.BlackPlayer(row,col);
                    if(board.updateBoardBlack(dataB.Item1 ,dataB.Item2 ,newBoard) == true)
                    {
                        ReverseBlackTest();
                        run++;
                    }
                }
                else
                {
                    Console.WriteLine("Unexpected error");
                }
                break;
            }
        }

        [TestMethod]
        public void ReverseBlackTest()
        {
            int row = 7;
            int col = 7;
            char [,] boardB = new char [8,8];
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

        [TestMethod]
        public void ReverseWhiteTest()
        {
            int row = 7;
            int col = 7;
            char [,] boardW = new char [8,8];
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
