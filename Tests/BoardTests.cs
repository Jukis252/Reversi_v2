using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace ReversiTests
{
    [TestClass]
    public class BoardTests
    {
        const int Rows = 8;
        const int Cols = 8;

        [TestMethod]
        public void CreateBoardTest()
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
        }
        [TestMethod]
        public void FillBoardTest()
        {
            CreateBoardTest();
        }

        [TestMethod]
        public void ShowBoardTest()
        {
            char[,] board = new char[8,8];
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

        [TestMethod]
        public void updateBoardBlackTest()
        {
            int row=7;
            int col=7;
            char[,] board = new char [8,8];
            if(board[row,col] == ' ')
            {
                board[row,col] = 'b';
                Console.WriteLine("Black works");
                //return true;

            }
            else
            {
                Console.WriteLine("Black error");
                Console.WriteLine("Invalid move");
                Thread.Sleep(5000);
                //return false;
            }
        }

        [TestMethod]
        public void updateBoardWhiteTest()
        {
            int row=7;
            int col=7;
            char[,] board = new char [8,8];
            if(board[row,col] == ' ')
            {
                board[row,col] = 'W';
                Console.WriteLine("White works");
                //return true;

            }
            else
            {
                Console.WriteLine("White error");
                Console.WriteLine("Invalid move");
                Thread.Sleep(5000);
                //return false;
            }
        }

    }
}
