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
        public Player playerOne;
        public Player playerTwo;
        
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
                    playerOne = new UserPlayer();
                    playerTwo = new UserPlayer();
                    break;
                case 1:
                    //Gameplay for c v p
                    playerOne = new UserPlayer();
                    playerTwo = new ComputerPlayer();
                    break;

                default:
                    Console.WriteLine("Enter either 0 or 1");
                    SetPlayers();
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
        public void DisplayGameRules()
        {
            Console.WriteLine("Enter the number of the choice youd like:");
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
            indicator = ((choices.Count + (playerOneChoice - playerTwoChoice)) % choices.Count);

            if (indicator == 0)
            {
                Console.WriteLine("{0} : {1}", playerOne.name, GetChoiceString(playerOneChoice));
                Console.WriteLine("{0} : {1}", playerTwo.name, GetChoiceString(playerTwoChoice));
                Console.WriteLine("It's a draw! Shoot again!");
            }
            else if(indicator % 2 == 1)
            {
                Console.WriteLine("{0} beats {1}! {2} wins!", 
                    GetChoiceString(playerOneChoice), 
                    GetChoiceString(playerTwoChoice), 
                    playerOne.name);
                playerOne.roundsWon++;
            }
            else if(indicator % 2 == 0)
            {
                Console.WriteLine("{0} beats {1}! {2} wins!",
                    GetChoiceString(playerTwoChoice),
                    GetChoiceString(playerOneChoice),
                    playerTwo.name);
                playerTwo.roundsWon++;
            }
        }
        public int GetUserInput()
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: {0} Enter an Integer.", e);
                return GetUserInput();
            }
            
        }

        public void CheckForWinner()
        {
            if(playerOne.roundsWon >= 2)
            {
                playerOne.didWin = true;
            }
            else if(playerTwo.roundsWon >= 2)
            {
                playerTwo.didWin = true;
            }
        }
        public void DisplayWinnerMessage()
        {
            if (playerOne.didWin)
            {
                Console.WriteLine("{0} won!", playerOne.name);
            }
            else
            {
                Console.WriteLine("{0} won!", playerTwo.name);
            }
        }
        public void RunGame()
        {
            int tempChoice1;
            int tempChoice2;
            while (playerOne.roundsWon < 2 && playerTwo.roundsWon < 2)
            {
                DisplayGameRules();
                DisplayChoices();
                Console.WriteLine("{0}'s Turn.", playerOne.name);
                tempChoice1 = playerOne.SelectChoice();
                Console.WriteLine("{0}'s Turn.", playerTwo.name);
                tempChoice2 = playerTwo.SelectChoice();
                
                CompareChoices(tempChoice1, tempChoice2);
                CheckForWinner();
            }
            DisplayWinnerMessage();
        }
    }
}
