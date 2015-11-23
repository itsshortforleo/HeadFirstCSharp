using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayPlanner
{
    class BirthdayParty
    {
        #region Properties
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecorations { get; set; }

        public string CakeWriting { get; set; }

        public int ActualLength
        {
            get
            {
                if (CakeWriting.Length>MaxWritingLength())
                {
                    return MaxWritingLength();
                }
                else
                {
                    return CakeWriting.Length;
                }
            }
        }
        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
            {
                return 8;
            }
            else
            {
                return 40;
            }
        }
        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
            {
                return 16;
            }
            else
            {
                return 40;
            }
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfDecorations;
        }

        #endregion Properties

        #region Constructor
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
        #endregion Constructor

    }
}
