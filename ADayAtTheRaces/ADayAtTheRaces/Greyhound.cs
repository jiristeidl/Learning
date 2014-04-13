using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox;
        public int Location;
        public Random randomizer;

        public bool Run()
        {
            int distance = randomizer.Next(1, 5);
            Location += distance;
            MyPictureBox.Left = Location;
            if (Location >= RaceTrackLength) return true;
            return false;           
        }
        public void TakeStartingPosition()
        {
            Location = StartingPosition;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
