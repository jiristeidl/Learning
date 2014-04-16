using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagement
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
            shiftNumber = 1;
        }

        public bool AssignWork(string job, int shifts)
        {
            foreach (Worker bee in workers)
            {
                if (bee.DoThisJob(job, shifts))
                    return true;
            }
            return false;
        }
        public string WorkTheNextShift()
        {
            string report = "";
            report += "Report for shift #" + shiftNumber++ + "\r\n";
            for (int i=0;i<workers.Length;i++)
            {
                if (workers[i].DidYouFinish())
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                else
                    report += "Worker #" + (i + 1) + " is doing '" + workers[i].CurrentJob + "' for " + workers[i].ShiftsLeft + " more shifts\r\n";
            }
            return report;
        }
    }
}
