using System;

namespace Reversi_V2
{
    internal class Work : PlayersTurn
    {
        private readonly PlayersTurn _turn = new PlayersTurn();
        private readonly ReverseElement _reverseElement = new ReverseElement();
        private const int Row = 0;
        private const int Col = 0;

        public ReverseElement ReverseElement
        {
            get { return _reverseElement; }
        }

        public void Start()
        {
            char [,] newBoard = ReverseElement.Board.CreateBoard();
            int run = 1;
            while(run<60)
            {
                Console.Clear();
                ReverseElement.Board.ShowBoard(newBoard);
                if(run%2 == 0)
                {
                    var dataW = _turn.WhitePlayer(Row,Col);
                    if(ReverseElement.Board.UpdateBoardWhite(dataW.Item1 ,dataW.Item2,newBoard))
                    {
                        ReverseElement.ReverseWhite(dataW.Item1,dataW.Item2,newBoard,run);
                        run++;
                    }
                }
                else if(run%2 != 0)
                {
                    var dataB = _turn.BlackPlayer(row: Row,Col);
                    if(ReverseElement.Board.UpdateBoardBlack(dataB.Item1 ,dataB.Item2 ,newBoard))
                    {
                        ReverseElement.ReverseBlack(dataB.Item1,dataB.Item2,newBoard,run);
                        run++;
                    }
                }
                else
                {
                    Console.WriteLine("Unexpected error");
                }

            }
        }
    }
}
