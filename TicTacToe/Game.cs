using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class Game
    {
        private char[,] board;

        public Game()
        {
            board = new char[,] { { '-', '-', '-' }, { '-', '-', '-' } , { '-', '-', '-' } };
        }

        public void makeMove(string move, char mark)
        {
            string[] posibleMoves = { "A1","A2","A3","B1","B2","B3","C1","C2","C3"};
            List<int[]> location = new List<int[]> { new int[] { 0, 0 }, new int[] { 1, 0 }, new int[] { 2, 0 }, new int[] { 0, 1 },
                new int[] { 1, 1 }, new int[] { 2, 1 } , new int[] { 0, 2 }, new int[] { 1, 2 } , new int[] { 2, 2 } };
            int mov = Array.IndexOf(posibleMoves, move);

            if(mov > -1)
            {
                int row = location[mov][0];
                int column = location[mov][1];

                if(board[row,column] == '-')
                {
                    board[row, column] = mark;
                }
                else
                {
                    throw new ArgumentException($"The move {nameof(move)} is invalid.");
                }
            }
            else
            {
                throw new ArgumentException($"The move {nameof(move)} is invalid.");
            }

        }

        public bool checkIfGameContinues(){

            for(int x = 0; x < board.GetLength(0); x++)
            {
                for(int y = 0; y < board.GetLength(1); y++)
                {
                    if(board[x,y] == '-')
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool checkIfPlayerWins(char mark)
        {
            bool firstDiagonal = board[0, 0] == mark && board[0, 1] == mark && board[0, 2] == mark;
            bool secondDiagonal = board[1, 0] == mark && board[1, 1] == mark && board[1, 2] == mark;
            bool thirdDiagonal = board[2, 0] == mark && board[2, 1] == mark && board[2, 2] == mark;
            bool firstHorizontal = board[0, 0] == mark && board[1, 0] == mark && board[2, 0] == mark;
            bool secondHorizontal = board[0, 1] == mark && board[1, 1] == mark && board[2, 1] == mark;
            bool thirdHorizontal = board[0, 2] == mark && board[1, 2] == mark && board[2, 2] == mark;
            bool firstAcross = board[0, 0] == mark && board[1, 1] == mark && board[2, 2] == mark;
            bool secondAcross = board[0, 2] == mark && board[1, 1] == mark && board[2, 0] == mark;

            if(firstDiagonal || secondDiagonal || thirdDiagonal || firstHorizontal || secondHorizontal || thirdHorizontal ||
                firstAcross || secondAcross)
            {
                return true;
            }

            return false;
        }

        public void displayBoard()
        {
            Console.WriteLine("   {0,-3}{1,-3}{2,-3}", 'A', 'B', 'C');
            Console.WriteLine("  ---------");

            for (int x = 0; x < board.GetLength(0); x++)
            {
                Console.Write("{0,-1}| ", x + 1);

                for(int y = 0; y < board.GetLength(1); y++)
                {
                    Console.Write("{0,-3}", board[x,y]);
                }

                Console.Write(Environment.NewLine);
            }
        }
    }
}
