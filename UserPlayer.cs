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
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice > 4 || choice < 0)
                {
                    Console.WriteLine("Error. Enter '0', '1', '2', '3', or '4'.");
                    return SelectChoice();
                }
                return choice;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: '{0}' Invalid Input. Please enter an integer '0 - 4'", e);
                return SelectChoice();
            }

                
        }


    }
}
