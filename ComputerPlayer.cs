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

        }

        //member methods
        public override int SelectChoice()
        {
            int choice;
            choice = rnd.Next(1, 6);
            return choice;
        }

    }
}
