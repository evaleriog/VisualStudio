using System;
namespace TicTacToe
{
    public class Match
    {
        private int tiedMatches;

        public int TiedMatches
        {
            get
            {
                return tiedMatches;
            }
        }

        public Match()
        {
            tiedMatches = 0;
        }

        public void playetsMatch(ref Player player1, ref Player player2)
        {
            int turn = 1;

            Game game = new Game();
            game.displayBoard();

            while (true)
            {
                if(turn == 1)
                {
                    Console.WriteLine($"{player1.Name} it is your turn....Select yoru move");
                    var playerMove = Console.ReadLine().ToUpper();

                    try
                    {
                        game.makeMove(playerMove, player1.Mark);
                        game.displayBoard();
                        turn = 2;

                        if (game.checkIfPlayerWins(player1.Mark))
                        {
                            player1.PlayerWon();
                            Console.WriteLine($"Loooks like {player1.Name} gets the win...");
                            break;
                        }

                        if (!game.checkIfGameContinues())
                        {
                            tiedMatches++;
                            Console.WriteLine("The match ended with a tie.....");
                            break;
                        }
                    }catch(ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    
                }else if(turn == 2)
                {
                    Console.WriteLine($"{player2.Name} it is your turn....Select yoru move");
                    var playerMove = Console.ReadLine().ToUpper();

                    try
                    {
                        game.makeMove(playerMove, player2.Mark);
                        game.displayBoard();
                        turn = 1;

                        if (game.checkIfPlayerWins(player2.Mark))
                        {
                            player2.PlayerWon();
                            Console.WriteLine($"Loooks like {player2.Name} gets the win...");
                            break;
                        }

                        if (!game.checkIfGameContinues())
                        {
                            tiedMatches++;
                            Console.WriteLine("The match ended with a tie.....");
                            break;
                        }
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Statistics from this players: ");
            Console.WriteLine($"{player1.Name} has won {player1.GamesWon} games.");
            Console.WriteLine($"{player2.Name} has won {player2.GamesWon} games.");
            Console.WriteLine($"They both have tied in {TiedMatches} games. ");
            Console.WriteLine("");
        }
    }
}
