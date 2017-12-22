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
        //(Rock, Paper, Scissors, Lizard, Spock)
        public int numberOfChoices = 5;
        
       
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
            int playerOneChoice;
            int playerTwoChoice;
            playerOneChoice = playerone.SelectChoice();
            playerTwoChoice = playertwo.SelectChoice();
            int indicator;
            indicator = (numberOfChoices + (playerOneChoice - playerTwoChoice) % 5);

            if(indicator % 2 == 1)
            {
                Console.WriteLine("{0} beats {1}! {2} wins!", 
                    getChoiceString(playerOneChoice), 
                    getChoiceString(playerTwoChoice), 
                    playerone.name);
                playerone.roundsWon++;
            }
            else if(indicator % 2 == 0)
            {
                Console.WriteLine("{0} beats {1}! {2} wins!",
                    getChoiceString(playerTwoChoice),
                    getChoiceString(playerOneChoice),
                    playertwo.name);
                playertwo.roundsWon++;
            }else
            {
                Console.WriteLine("It's a draw! Shoot again!");
            }
        }
        public int GetUserInput()
        {
            return Console.Read();
        }

        public void CheckForWinner()
        {
            if(playerone.roundsWon >= 2)
            {
                playerone.didWin = true;
            }
            else if(playertwo.roundsWon >= 2)
            {
                playertwo.didWin = true;
            }
        }
        public void DisplayWinnerMessage()
        {
            if (playerone.didWin)
            {
                Console.WriteLine("{0} wone with a score of {1}", playerone.name, playerone.roundsWon
                    );
            }
            else
            {
                Console.WriteLine("{0} won with a score of {1}", playertwo.name, playertwo.roundsWon);
            }
        }
        public void RunGame()
        {
            SetPlayers();
            while (playerone.roundsWon < 2 && playertwo.roundsWon < 2)
            {
                playerone.SelectChoice();
                playertwo.SelectChoice();
                CompareChoices();
                CheckForWinner();
            }
            DisplayWinnerMessage();
        }
    }
}
