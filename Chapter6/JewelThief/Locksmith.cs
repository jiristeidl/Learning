using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelThief
{
    class Locksmith
    {
        private string writtenDownCombination;
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        virtual public void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }
        internal void WriteDownCombination(string safeCombination)
        {
            writtenDownCombination = safeCombination;
        }
    }
}
