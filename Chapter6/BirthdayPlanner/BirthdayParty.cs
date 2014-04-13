using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayPlanner
{
    class BirthdayParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecoration { get; set; }
        const int CostOfFood = 25;        
        public string CakeWriting { get; set; }
        private int actualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
            }            
        }
        public bool CakeWritingTooLong{
            get{
                if(CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost=0;
                totalCost += NumberOfPeople * CostOfFood;
                totalCost += CalculateCostOfDecorations();
                totalCost += (CakeSize() == 8) ? 40M + actualLength * 0.25M : 75M + actualLength * 0.25M;
                return totalCost;

            }
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }
        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }
        private decimal CalculateCostOfDecorations(){
            decimal total = 0;
            if(FancyDecoration){
                total += NumberOfPeople * 15.0M;
                total += 50.0M;
            }else{
                total+=NumberOfPeople*7.5M;
                total+=30.0M;
            }
            return total;
        }
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecoration = fancyDecorations;
            CakeWriting = cakeWriting;
        }        
    }
}
