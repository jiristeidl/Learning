using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeeHiveManagement
{
    class Worker : Bee
    {
        private string currentJob;
        public string CurrentJob
        {
            get
            {
                if (string.IsNullOrEmpty(currentJob))
                    return "";
                else
                    return currentJob;
            }
        }
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked=0;
        const double honeyUnitsPerShiftWorked = 0.65;

        internal bool DoThisJob(string job, int shifts)
        {
            if (string.IsNullOrEmpty(CurrentJob))
            {
                foreach (string canDo in jobsICanDo)
                {
                    if (canDo.Equals(job))
                    {
                        currentJob = job;
                        shiftsToWork = shifts;
                        shiftsWorked = 0;
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }
        internal bool DidYouFinish()
        {
            shiftsWorked++;
            if (CurrentJob == "")
                return false;
            if (shiftsToWork == shiftsWorked)
            {
                currentJob = "";
                shiftsToWork = 0;
                return true;
            }
            else
                return false;
        }
        public override double HoneyConsumtionRate()
        {
            return base.HoneyConsumtionRate() + shiftsWorked*honeyUnitsPerShiftWorked;
        }

        public Worker(string[] jobs, double weightMg) : base(weightMg)
        {
            jobsICanDo = jobs;
        }
    }
}
