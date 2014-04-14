using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayPlanner
{
    class Party
    {
        public int NumberOfPeople { get; set; }
        const int CostOfFood = 25;
        public bool FancyDecoration { get; set; }
        virtual public decimal Cost
        {
            get
            {
                decimal total = 0;
                total += NumberOfPeople * CostOfFood;
                total += CalculateCostOfDecorations();
                if (NumberOfPeople > 12) total += 100M;
                return total;
            }
        }
        private decimal CalculateCostOfDecorations()
        {
            decimal total = 0;
            if (FancyDecoration)
            {
                total += NumberOfPeople * 15.0M;
                total += 50.0M;
            }
            else
            {
                total += NumberOfPeople * 7.5M;
                total += 30.0M;
            }
            return total;
        }
    }
}
