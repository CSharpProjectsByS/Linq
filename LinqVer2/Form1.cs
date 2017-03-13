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
        private MethodChooser methodChooser;
        private List<int> itemsCollection;
        private Random random;

        

        public Form1()
        {
            InitializeComponent();
            methodChooser = new MethodChooser();

            methodChooser.greaterTVTB = GreaterTVTB;
            methodChooser.modVTB = ModVTB;
            methodChooser.xMultiplyTB = XMultiplyTB;
            methodChooser.xPowTB = XPowTB;

            itemsCollection = new List<int>();
            random = new Random();

            GreaterTZRB.Checked = true;
            AscendingRB.Checked = true;
            X2RB.Checked = true;
        }

        


        private void GreaterTZRB_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.isGreaterThanZero = GreaterTZRB.Checked;
        }

        private void SmallerTZRB_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.isSmallerThanZero = SmallerTZRB.Checked;
        }

        private void GreaterTV_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.isGreaterThanValue = GreaterTV.Checked;
        }

        private void EvenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.isMod2 = EvenRadioButton.Checked;
        }

        private void ModVRB_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.isModByV = ModVRB.Checked;
        }


        private void AscendingRB_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.isAscending = AscendingRB.Checked;
        }

        private void DescendingRB_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.isDescending = DescendingRB.Checked;
        }

        private void AscendingaABCRB_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.isAscendingABC = AscendingaABCRB.Checked;
        }

        private void DescendingABCRB_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.isDescendingABC = DescendingABCRB.Checked;
        }

        private void X2RB_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.is2X = X2RB.Checked;
        }

        private void XXRB_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.isXX = XXRB.Checked;
        }

        private void XMultiplyRB_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.isXMultiplyX = XMultiplyRB.Checked;
        }

        private void XPowRB_CheckedChanged(object sender, EventArgs e)
        {
            methodChooser.isXPow = XPowRB.Checked;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            RunProperLinq3Selection();
        }

        private void AddToCollectionButton_Click(object sender, EventArgs e)
        {
            int newValue = Int32.Parse(NewValue.Text);
            itemsCollection.Add(newValue);
            CollectionLB.Items.Add(newValue);
        }

        private void RemoveFromCButton_Click(object sender, EventArgs e)
        {
            int index = CollectionLB.SelectedIndex;
            CollectionLB.Items.RemoveAt(index);
            itemsCollection.RemoveAt(index);
        }

        private void ResetCollectB_Click(object sender, EventArgs e)
        {
            itemsCollection.Clear();
            CollectionLB.Items.Clear();
        }

        private void RandNewValuesB_Click(object sender, EventArgs e)
        {
            AddRandomValuesToCollection();
        }

        private void GoFirstAloneButton_Click(object sender, EventArgs e)
        {
            UpadteOldCollectionView();
            itemsCollection = methodChooser.RunWhereLinqGroup(itemsCollection);
            ShowCollectionInListBox();
        }

        private void GoSecondAloneButton_Click(object sender, EventArgs e)
        {
            UpadteOldCollectionView();
            itemsCollection = methodChooser.RunSortingLinqGroup(itemsCollection);
            ShowCollectionInListBox();
        }

        private void GoThirdAlone_Click(object sender, EventArgs e)
        {
            UpadteOldCollectionView();
            itemsCollection = methodChooser.RunSelectLinqGroup(itemsCollection);
            ShowCollectionInListBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpadteOldCollectionView();
            GreaterTZRB.Checked = true;
            AscendingRB.Checked = true;
            X2RB.Checked = true;

            itemsCollection = itemsCollection.Where(n => n > 0)
                .OrderBy(n => n)
                .Select(n => n * 2).ToList();

            ShowCollectionInListBox();
        }

        private void Komb2B_Click(object sender, EventArgs e)
        {
            UpadteOldCollectionView();
            SmallerTZRB.Checked = true;
            DescendingRB.Checked = true;
            XXRB.Checked = true;

            var itemsCollection2 = from n in itemsCollection
                                   where n < 0
                                   orderby n descending
                                   select n * n;

            itemsCollection = itemsCollection2.ToList();

            ShowCollectionInListBox();
        }

        private void RunProperLinq3Selection()
        {
            UpadteOldCollectionView();
            itemsCollection = methodChooser.RunWhereLinqGroup(itemsCollection);
            itemsCollection = methodChooser.RunSortingLinqGroup(itemsCollection);
            itemsCollection = methodChooser.RunSelectLinqGroup(itemsCollection);
            ShowCollectionInListBox();
        }

        private void AddRandomValuesToCollection()
        {
            int amount = Int32.Parse(AmountOfNewCollection.Text);
            int i = 0;
            while (i < amount)
            {
                int newValue = random.Next(-10, 10);
                itemsCollection.Add(newValue);
                CollectionLB.Items.Add(newValue);
                i++;
            }
        }

        private void ShowCollectionInListBox()
        {
            CollectionLB.Items.Clear();
            foreach (int number in itemsCollection)
            {
                CollectionLB.Items.Add(number);
            }
        }

        private void UpadteOldCollectionView()
        {
            OldCollectionLB.Items.Clear();

            foreach (int number in itemsCollection)
            {
                OldCollectionLB.Items.Add(number);
            }
        }

        
    }
}
