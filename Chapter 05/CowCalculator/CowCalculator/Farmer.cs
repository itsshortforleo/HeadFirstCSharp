using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Head_First_C_Sharp.Chapter_05.CowCalculator.CowCalculator
{
    class Farmer
    {
        public int BagsOfFeed;
        public const int FeedMultiplier = 30;

        private int numberOfCows;

        public int NumberOfCows
        {
            get { return numberOfCows; }
            set 
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
        
    }
}
