using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter5
{
    class DinnerParty
    {

        public int NumberOfPeople { get; set; }
        public bool FancyDecoration { get; set; }
        public bool HealthyOption { get; set; }
        public decimal Cost
        {
            get
            {
                decimal total = NumberOfPeople * 25.0M;
                total += FancyDecoration ? (NumberOfPeople * 15.0M + 50.0M) : (NumberOfPeople * 7.5M + 30.0M);
                if (HealthyOption)
                {
                    total += NumberOfPeople * 5.0M;
                    total *= 0.95M;
                }
                else
                {
                    total += NumberOfPeople * 20.0M;
                }
                return total;
            }
        }
        public DinnerParty(int numberOfPeople, bool fancyDecoration, bool healthyOption)
        {
            this.NumberOfPeople = numberOfPeople;
            this.FancyDecoration = fancyDecoration;
            this.HealthyOption = healthyOption;
        }
    }
}
