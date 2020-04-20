using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1, Please enter your name: ");
            var name = Console.ReadLine();
            Player player1 = new Player(name, 'X');

            Console.WriteLine("Player 2, Please enter your name: ");
            name = Console.ReadLine();
            Player player2 = new Player(name, 'O');

            Console.WriteLine($"Perfect, {player1.Name} you will be {player1.Mark}");
            Console.WriteLine($"and {player2.Name} you will be {player2.Mark}");

            Match match = new Match();

            while (true)
            {
                match.playetsMatch(ref player1, ref player2);

                Console.WriteLine("Do you want to play another game? Y/N");
                var res = Console.ReadLine().ToUpper();

                if(res == "N" || res == "n")
                {
                    break;
                }
            }
            
        }
    }
}
