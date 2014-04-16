using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagement
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber;
       

        public Queen(Worker[] workers,double weightMg ) : base(weightMg)
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
            double honeyTotal = this.HoneyConsumtionRate();
            report += "Report for shift #" + shiftNumber++ + "\r\n";
            for (int i=0;i<workers.Length;i++)
            {
                honeyTotal += workers[i].HoneyConsumtionRate();
                if (workers[i].DidYouFinish())
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                else if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                else
                    report += "Worker #" + (i + 1) + " is doing '" + workers[i].CurrentJob + "' for " + workers[i].ShiftsLeft + " more shifts\r\n";
            }
            report += "Total honey consumed for the shift: " + honeyTotal + " units\r\n";
            return report;
        }
    }
}
