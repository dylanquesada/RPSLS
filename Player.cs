using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        
        public int choice;
        public int GetChoice()
        {
            List<string> choices = new List<string>();
            choices.Add("rock");
            choices.Add("paper");
            choices.Add("scissors");
            choices.Add("lizard");
            choices.Add("spock");
            return choice;
        }
        

    }
}
