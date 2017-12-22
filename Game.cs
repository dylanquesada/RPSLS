using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        // member variables
        public List<string> choices = new List<string>();
        public Player playerone;
        public Player playertwo;
       
        // constructor 
        public Game()
        {
            
        }
        // member methods
        public void SetPlayers()
        {
            Console.WriteLine("How many computers would you like?");
            Console.WriteLine("0 computers = human player vs. human player");
            Console.WriteLine("1 computers = human player vs. computer player");
            int userInput = GetUserInput();
            switch (userInput)
            {
                case 0:
                    //Gameplay for p v p
                    playerone = new UserPlayer();
                    playertwo = new UserPlayer();
                    break;
                case 1:
                    //Gameplay for c v p
                    playerone = new UserPlayer();
                    playertwo = new ComputerPlayer();
                    break;

                default:
                    Console.WriteLine("Enter either 0 or 1");
                    SetPlayers();
                    break;
            }

        }
        public void CompareChoices()
        {
            if(/*Player one wins*/)
            {
                PlayerOneScore.score++;
            }
            else if(/*Player two wins*/)
            {
                // PlayerTwoScore++;
            }else
            {
                //Tie -- nothing happens
            }
        }
        public int GetUserInput()
        {
            return Console.Read();
        }
       
            public void RunGame(int userInput)
        {
            int matchCounter = 0;
            while (matchCounter < 3)
            {
              
               
            }
        }
    }
}
