using System;
namespace TicTacToe
{
    public class Player
    {
        private string name;
        private int gamesWon;
        private char mark;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int GamesWon
        {
            get
            {
                return gamesWon;
            }
        }

        public char Mark
        {
            get
            {
                return mark;
            }
        }

        public Player(string name, char mark)
        {
            this.name = name;
            this.mark = mark;
            gamesWon = 0;
        }

        public void PlayerWon()
        {
            gamesWon++;
        }

    }
}
