using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contructorTest
{
    class MySubclass : MyBaseClass
    {
        public MySubclass(string baseClassNeedsThis, int anotheValue) : base(baseClassNeedsThis)
        {
            MessageBox.Show("This is the subclass: " + baseClassNeedsThis + " and " + anotheValue);
        }
    }
}
