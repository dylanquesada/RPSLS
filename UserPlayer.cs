﻿using System;
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

        // member methods
        public override int SelectChoice()
        {
            int choice;
            choice = Console.Read();
            return choice;
        }


    }
}
