using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectSwap
{
    public partial class Form1 : Form
    {
        Elephant lloyd = new Elephant();
        Elephant lucinda = new Elephant();
                       
        public Form1()
        {
            lloyd.Name = "Lloyd";
            lloyd.EarSize = 40;
            lucinda.Name = "Lucinda";
            lucinda.EarSize = 33;
            InitializeComponent();
        }

        private void LloydButton_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void LucindaButton_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            Swap();
        }

        private void Swap()
        {
            Elephant temp;
            temp = lucinda;
            lucinda = lloyd;
            lloyd = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hi", lucinda);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lloyd.SpeakTo(lucinda, "Hello");
        }
    }
}
