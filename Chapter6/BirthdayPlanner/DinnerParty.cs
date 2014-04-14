using BirthdayPlanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter5
{
    class DinnerParty : Party  
    {
        public bool HealthyOption { get; set; }
        override public decimal Cost
        {
            get
            {
                decimal total = base.Cost;                
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
