using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4
{
    public partial class Form1 : Form
    {
        int start = 0;
        int end = 0;
        double milesTraveled = 0;
        double reimburseRate = 0.39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start =(int)StartingMileage.Value;
            end = (int)EndingMileage.Value;
            if (start < end)
            {
                milesTraveled = end - start;
                amountOwed = milesTraveled * reimburseRate;
                Owed.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("The starting mileage must be less then the ending mileage.", "Cannot Calculate Mileage");
            }
        }
    }
}
