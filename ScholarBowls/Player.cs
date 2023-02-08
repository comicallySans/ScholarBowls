using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarBowls
{
    //Player class for an individual player
    class Player
    {
        //parameters like individual points, their buzzer number, etc.
        public int pointVal;
        public int buzzNum;

        public void getPoints()
        {
            Console.Write("Player " + buzzNum + " has "+ pointVal + " points"); 

        }

    }
}
