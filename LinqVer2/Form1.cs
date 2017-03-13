using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqVer2
{
    public partial class Form1 : Form
    {

        private bool isGreaterThanZero = true;
        private bool isSmallerThanZero = false;
        private bool isGreaterThanValue = false;
        private bool isMod2 = false;
        private bool isModByV = false;

        private bool isAscending = true;
        private bool isDescending = false;
        private bool isAscendingABC = false;
        private bool isDescendingABC = false;

        private bool is2X = true;
        private bool isXX = false;
        private bool isXMultiplyX = false;
        private bool isXPow = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }



        private void AddToCollectionButton_Click(object sender, EventArgs e)
        {

        }

        private void GreaterTZRB_CheckedChanged(object sender, EventArgs e)
        {
            isGreaterThanZero = GreaterTZRB.Checked;
        }

        private void SmallerTZRB_CheckedChanged(object sender, EventArgs e)
        {
            isSmallerThanZero = SmallerTZRB.Checked;
        }

        private void GreaterTV_CheckedChanged(object sender, EventArgs e)
        {
            isGreaterThanValue = GreaterTV.Checked;
        }

        private void EvenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isMod2 = EvenRadioButton.Checked;
        }

        private void ModVRB_CheckedChanged(object sender, EventArgs e)
        {
            isModByV = ModVRB.Checked;
        }


        private void AscendingRB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
