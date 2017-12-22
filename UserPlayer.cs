using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class UserPlayer : Player
    {
        // member variables

        // constructor
        public UserPlayer()
        {
            Console.WriteLine("What is Player's Name?");
            name = Console.ReadLine();
        }

        // member methods

        public override int SelectChoice()
        {
            int choice;
            
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }


    }
}
