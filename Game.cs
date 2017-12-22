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
        //Maybe change this to choices.Length?
        
        // constructor 
        public Game()
        {
            PopulateChoicesList();
            SetPlayers();
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
                    break;
            }

        }
        public string GetChoiceString(int choice)
        {
            return choices[choice];
        }
        public void PopulateChoicesList()
        {
            
            choices.Add("Rock");
            choices.Add("Paper");
            choices.Add("Scissors");
            choices.Add("Spock");
            choices.Add("Lizard");
            

        }
        public void DisplayChoices()
        {
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine(i + ". For {0}", choices[i]);
            }
        }
        public void CompareChoices(int choice1, int choice2)
        {
            int playerOneChoice = choice1;
            int playerTwoChoice = choice2;
            int indicator;
            indicator = ((numberOfChoices + (playerOneChoice - playerTwoChoice)) % numberOfChoices);

            if (indicator == 0)
            {
                Console.WriteLine("{0} : {1}", playerone.name, GetChoiceString(playerOneChoice));
                Console.WriteLine("{0} : {1}", playertwo.name, GetChoiceString(playerTwoChoice));
                Console.WriteLine("It's a draw! Shoot again!");
            }
            else if(indicator % 2 == 1)
            {
                Console.WriteLine("{0} beats {1}! {2} wins!", 
                    GetChoiceString(playerOneChoice), 
                    GetChoiceString(playerTwoChoice), 
                    playerone.name);
                playerone.roundsWon++;
            }
            else if(indicator % 2 == 0)
            {
                Console.WriteLine("{0} beats {1}! {2} wins!",
                    GetChoiceString(playerTwoChoice),
                    GetChoiceString(playerOneChoice),
                    playertwo.name);
                playertwo.roundsWon++;
            }
        }
        public int GetUserInput()
        {
            return Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("{0} won!", playerone.name);
            }
            else
            {
                Console.WriteLine("{0} won!", playertwo.name);
            }
        }
        public void RunGame()
        {
            
            while (playerone.roundsWon < 2 && playertwo.roundsWon < 2)
            {
                DisplayChoices();
                CompareChoices(playerone.SelectChoice(),
                playertwo.SelectChoice());
                CheckForWinner();
            }
            DisplayWinnerMessage();
        }
    }
}
