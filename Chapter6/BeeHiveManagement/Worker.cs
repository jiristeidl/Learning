using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeeHiveManagement
{
    class Worker
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
        public int ShiftsLeft { get; }
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        internal bool DoThisJob(string job, int shifts)
        {
            if (string.IsNullOrEmpty(CurrentJob))
            {
                foreach (string canDo in jobsICanDo)
                {
                    if (canDo.Equals(job))
                        return true;
                }
                return false;
            }
            else
                return false;
        }
        internal bool DidYouFinish()
        {
            throw new NotImplementedException();
        }        
    }
}
