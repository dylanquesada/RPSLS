using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ComputerPlayer : Player
    {
        //member variables
        public Random rnd;

        //constructor
        public ComputerPlayer()
        {
            name = "RPSLS Bot";
            Console.WriteLine("Player Two is called {0}.", name);
        }

        //member methods
        public override int SelectChoice()
        {
            int choice;
            rnd = new Random();
            choice = rnd.Next(0, 5);
            return choice;
        }

    }
}
