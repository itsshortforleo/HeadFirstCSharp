using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlannerBirthday
{
    public class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }


        public decimal CostOfBeveragesPerPerson;
        public const int CostOfFoodPerPerson = 25;
        private decimal cost;

        public decimal Cost
        {
            get
            {
                Decimal totalCost = (NumberOfPeople * (CostOfFoodPerPerson + CalculateCostOfBeveragesPerPerson()));
                totalCost += CalculateCostOfDecorations();
                if (NumberOfPeople > 12)
                {
                    totalCost += 100M;
                }
                return totalCost = HealthyOption ? totalCost * 0.95M : totalCost;
            }
            set { cost = value; }
        }


        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            return costOfDecorations = FancyDecorations ? (NumberOfPeople * 15.00M) + 50M : (NumberOfPeople * 7.50M) + 30M;

        }
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return CostOfBeveragesPerPerson = HealthyOption ? 5M : 20M;
        }
    }
}
