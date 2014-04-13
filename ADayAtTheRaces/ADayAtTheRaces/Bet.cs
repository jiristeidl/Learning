using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayAtTheRaces
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        internal string GetDescription()
        {
            if (Amount > 0)
            {
                return Bettor.Name + " bets " + Amount + " on dog #" + Dog;
            }
            else return Bettor.Name + " hasn't placed a bet";
        }
        internal int PayOut(int Winner)
        {
            if (Dog == Winner) return Amount;
            else return Amount - (2 * Amount);
        }
    }
}
