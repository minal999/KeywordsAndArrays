using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class MaxOfArray
    {
    public int[] arr = new int[10]  { 10, 32, 45, 90, 98,55,74,1,22,7 };

        public int maximum()
        {
            int i;
            int max = arr[0];

            for (i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            return max;
        }
    }
}
