using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    internal class Scoreboard : Player
    {
        
        private int player1;
        private int player2;
        private int roundCount;


        
        

        public void DisplayScoreBoard(int player1, int player2)
        {
            // Display players current Score:
            this.player1 = player1;
            this.player2 = player2;
            Console.WriteLine("Player 1 Score : " + player1);
            Console.WriteLine("Player 2 Score : " + player2);

            Console.ReadLine();


            // "If" Method that checks if game is done:
            if (roundCount == 15)
            {

                Console.WriteLine("Game Over ");


            }
            else
            {
                Console.WriteLine("Next Round");
            }


        }

    }
}
