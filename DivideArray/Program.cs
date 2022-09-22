using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideArray
{
    internal class Program
    {
        static int findSplitPoint(int[] arr, int n)
        {

            int leftSum = 0;

            for (int i = 0; i < n; i++)
            {

                leftSum += arr[i];

                int rightSum = 0;

                for (int j = i + 1; j < n; j++)
                    rightSum += arr[j];

 
                if (leftSum == rightSum)
                    return i + 1;
            }

            return -1;
        }

        static void printTwoParts(int[] arr, int n)
        {

            int splitPoint = findSplitPoint(arr, n);

            if (splitPoint == -1 || splitPoint == n)
            {
                Console.Write("Not Possible");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (splitPoint == i)
                    Console.WriteLine();

                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int n = arr.Length;
            printTwoParts(arr, n);
        }
    }
}
