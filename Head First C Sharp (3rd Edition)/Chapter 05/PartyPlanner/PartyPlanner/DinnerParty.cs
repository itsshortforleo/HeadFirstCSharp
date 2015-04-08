using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    public class DinnerParty
    {
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;
        public const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool healthyOption)
        {
            CostOfBeveragesPerPerson = healthyOption ? 5M : 20M;
        }
        public void CalculateCostOfDecorations(bool fancyBoxChecked)
        {
            if (fancyBoxChecked)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            //CostOfDecorations = fancyBoxChecked ? ((NumberOfPeople * 15M) + 50M) : ((NumberOfPeople * 7.5M) + 30M);
        }
        public Decimal CalculateCost(bool healthyBoxChecked)
        {
            Decimal totalCost = ((NumberOfPeople * (CostOfFoodPerPerson + CostOfBeveragesPerPerson)) + CostOfDecorations);
            return totalCost = healthyBoxChecked ? totalCost * 0.95M : totalCost;
        }
    }
}
