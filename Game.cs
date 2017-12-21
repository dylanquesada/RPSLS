using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public void StartGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock - BEST OUT OF THREE.");
            Console.WriteLine("How many computers would you like?");
            Console.WriteLine("0 computers = human player vs. human player");
            Console.WriteLine("1 computers = human player vs. computer player");
            Console.WriteLine("2 computers = computer player vs. computer player");
            int userInput = GetUserInput();
        }
        public int GetUserInput()
        {
            return Console.Read();
        }
    }
}
