using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    class Guy
    {
        public string Name;
        public int Money;
        public Bet MyBet;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabel()
        {
            MyLabel.Text =MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Money + " bucks";
        }
        public void ClearBet()
        {
            if (MyBet == null)
            {
                MyBet = new Bet() { Bettor = this };
            }
            MyBet.Amount = 0;
        }
        public bool PlaceBet(int BetAmount,int DogToWin)
        {
            if (BetAmount <= Money)
            {
                MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this };
                return true;
            }
            else return false;
        }
        public void Collect(int Winner)
        {
            Money += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabel();
        }
    }
}
