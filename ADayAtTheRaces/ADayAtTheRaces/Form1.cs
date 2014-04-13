using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        Guy[] guys=new Guy[3];
        Greyhound[] hounds = new Greyhound[4];
        Random myRnd = new Random();

        public Form1()
        {
            InitializeComponent();
            Guy joe = new Guy() { Name = "Joe", Money = 50, MyRadioButton = joesRadioB, MyLabel = joeBetLabel };
            Guy john = new Guy() { Name = "John", Money = 45, MyRadioButton = johnRadioB, MyLabel = johnBetLabel };
            Guy bob = new Guy() { Name = "Bob", Money = 75, MyRadioButton = bobRadioB, MyLabel = bobBetLabel };
            minimumBetLabel.Text = "Minimum bet: " + betPicker.Minimum + " bucks";            
            guys[0] = joe;
            guys[1] = bob;
            guys[2] = john;            
            for (int i = 0; i < hounds.Length;i++ )
            {
                if (hounds[i] == null)
                {
                    hounds[i] = new Greyhound() { StartingPosition = dog1.Left, RaceTrackLength = raceTrack.Width,randomizer=myRnd };
                }
            }
            hounds[0].MyPictureBox = dog1;
            hounds[1].MyPictureBox = dog2;
            hounds[2].MyPictureBox = dog3;
            hounds[3].MyPictureBox = dog4;
            houndsStart(hounds);
            noBets(guys);
        }

        private void houndsStart(Greyhound[] hounds)
        {
            foreach (Greyhound hound in hounds)
            {
                hound.TakeStartingPosition();
            }
        }

        private void noBets(Guy[] guys)
        {
            foreach (Guy guy in guys)
            {
                guy.ClearBet();
                guy.UpdateLabel();
            }
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            Guy dude = null; ;
            
            if(joesRadioB.Checked==true) dude = guys[0];
            if(bobRadioB.Checked==true) dude = guys[1];
            if(johnRadioB.Checked==true) dude = guys[2];
            
           
            placeBetForGuy(dude,(int)betPicker.Value,(int)dogPicker.Value);
        }

        private void placeBetForGuy(Guy dude, int p, int dog)
        {
            dude.MyBet.Amount = p;
            dude.MyBet.Dog = dog;
            dude.UpdateLabel();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool finnished = false;
            int winner=0;
            houndsStart(hounds);
            while (!finnished)
            {
                bettingParlorBox.Enabled = false;
                for (int i = 0; i < hounds.Length; i++)
                {
                    finnished = hounds[i].Run();
                    if (finnished)
                    {
                        winner = i + 1;
                        break;
                    }
                }
                System.Threading.Thread.Sleep(5);
            }
            bettingParlorBox.Enabled = true;
            MessageBox.Show("The winner is dog #" + winner);
            foreach (Guy guy in guys)
            {
                guy.Collect(winner);
            }
        }
    }
}
