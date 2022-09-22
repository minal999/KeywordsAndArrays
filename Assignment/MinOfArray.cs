using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class MinOfArray
    {
        public int[] arr = new int[10] { 10, 32, 45, 90, 98, 55, 74, 1, 22, 7 };

        public int minimum()
        {
            int i;
            int min = arr[0];

            for (i = 1; i < arr.Length; i++)
                if (arr[i] < min)
                    min = arr[i];

            return min;
        }
    }
}
