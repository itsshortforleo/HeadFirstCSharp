using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyWithInheritance
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                
                totalCost = (NumberOfPeople * (CostOfFoodPerPerson + CalculateCostOfBeveragesPerPerson()));
                totalCost += CalculateCostOfDecorations();
               
                return totalCost = HealthyOption ? totalCost * 0.95M : totalCost;
            }
            
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            return costOfDecorations = FancyDecorations ? (NumberOfPeople * 15.00M) + 50M : (NumberOfPeople * 7.50M) + 30M;

        }
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson = 0;
            //if (HealthyOption)
            //{
            //    costOfBeveragesPerPerson = 5.00M;
            //}
            //else
            //{
            //    costOfBeveragesPerPerson = 20.00M;
            //}
            return costOfBeveragesPerPerson = HealthyOption ? 5M : 20M;
        }
    }
}
