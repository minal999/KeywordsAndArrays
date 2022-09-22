using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Duplicate
    {
        int[] arr = new int[] { 1, 2, 3, 2, 4, 3, 5 };

        public int find()
        {
            Console.WriteLine("Duplicate elements in given array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[j]);
                    }
                }
            }
            return 0;
        }
    }
}
