using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGames
{
    class Stats
    {
        public int Total=0;
        public int Missed=0;
        public int Correct=0;
        public int Accuracy;

        public void Update(bool correctKey)
        {
            Total++;
            if(!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }

            Accuracy = 100 * Correct / (Missed + Correct);
        }
    }
}
