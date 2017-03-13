using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqVer2
{
    class MethodChooser
    {
        public bool isGreaterThanZero = true;
        public bool isSmallerThanZero = false;
        public bool isGreaterThanValue = false;
        public bool isMod2 = false;
        public bool isModByV = false;

        public bool isAscending = true;
        public bool isDescending = false;
        public bool isAscendingABC = false;
        public bool isDescendingABC = false;

        public bool is2X = true;
        public bool isXX = false;
        public bool isXMultiplyX = false;
        public bool isXPow = false;

        public TextBox greaterTVTB;
        public TextBox modVTB;
        public TextBox xMultiplyTB;
        public TextBox xPowTB;

        public List<int> RunWhereLinqGroup(List<int> list)
        {
            IEnumerable<int> newList = new List<int>();

            if (isGreaterThanZero)
            {
                newList = list.Where(n => n > 0);
            } 
            else if (isSmallerThanZero)
            {
                newList = list.Where(n => n < 0);
            }
            else if (isGreaterThanValue)
            {
                int value = Int32.Parse(greaterTVTB.Text);
                newList = list.Where(n => n > value);
            }
            else if (isMod2)
            {
                newList = list.Where(n => n % 2 == 0);
            }
            else if (isModByV)
            {
                int value = Int32.Parse(modVTB.Text);
                newList = list.Where(n => n % value == 0);
            }

            return newList.ToList();
        }

        public List<int> RunSortingLinqGroup(List<int> list)
        {
            IEnumerable<int> newList = new List<int>();

            if (isAscending)
            {
                newList = list.OrderBy(n => n);
            }
            else if (isDescending)
            {
                newList = list.OrderByDescending(n => n);
            }
            else if (isAscendingABC)
            {
                var stringList = list.Select(n => n.ToString());
                //var stringList2 = stringList.OrderBy(n => n);
                stringList = stringList.OrderBy(n => n);
                newList = stringList.Select(n => Int32.Parse(n));
            }
            else if (isDescendingABC)
            {
                var stringList = list.Select(n => n.ToString());
                //var stringList2 = stringList.OrderBy(n => n);
                stringList = stringList.OrderByDescending(n => n);
                newList = stringList.Select(n => Int32.Parse(n));
            }

            return newList.ToList();
        }

        public List<int> RunSelectLinqGroup(List<int> list)
        {
            IEnumerable<int> newList = new List<int>();

            if (is2X)
            {
                newList = list.Select(n => n * 2);
            }
            else if (isXX)
            {
                newList = list.Select(n => n * n);
            }
            else if (isXMultiplyX)
            {
                int value = Int32.Parse(xMultiplyTB.Text);
                newList = list.Select(n => n * value);
            }
            else if (isXPow)
            {
                int value = Int32.Parse(xPowTB.Text);
                newList = list.Select(n => (int) Math.Pow(n, value));
            }

            return newList.ToList();
        }

    }
}
