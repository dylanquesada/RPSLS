using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public int GetUserInput()
        {
            return Console.Read();
        }
        public void StartGame()
        {

            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock - BEST OUT OF THREE.");
            Console.WriteLine("How many computers would you like?");
            Console.WriteLine("0 computers = human player vs. human player");
            Console.WriteLine("1 computers = human player vs. computer player");
            Console.WriteLine("2 computers = computer player vs. computer player");
            int userInput = GetUserInput();

            RunGame(userInput);
        }
            public void RunGame(int userInput)
        {
            int matchCounter = 0;
            while (matchCounter < 3)
            {
                switch (userInput)
                {
                    case 0:
                        //Gameplay for p v p
                        break;
                    case 1:
                        //Gameplay for c v p
                        break;
                    case 2:
                        //Gameplay for c v c
                        break;

                    default:
                        Console.WriteLine("Enter either 1, 2, or 3.");
                        break;
                }
               
            }
        }
    }
}
