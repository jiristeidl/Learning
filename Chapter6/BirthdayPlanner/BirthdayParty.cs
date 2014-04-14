using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayPlanner
{
    class BirthdayParty : Party
    {
                
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

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;                
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
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecoration = fancyDecorations;
            CakeWriting = cakeWriting;
        }        
    }
}
