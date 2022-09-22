using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArray
{
    internal class Program
    {
        int subArraySum(int[] arr, int n,
                               int sum)
        {
            int curr_sum = arr[0],
                     start = 0, i;

            for (i = 1; i <= n; i++)
            {
                while (curr_sum > sum &&
                       start < i - 1)
                {
                    curr_sum = curr_sum -
                               arr[start];
                    start++;
                }

                if (curr_sum == sum)
                {
                    int p = i - 1;
                    Console.WriteLine("Sum found between " +
                                         "indexes " + start +
                                               " and " + p);
                    return 1;
                }

                if (i < n)
                    curr_sum = curr_sum + arr[i];

            }
            Console.WriteLine("No subarray found");
            return 0;
        }

        static void Main(string[] args)
        {
            Program sa = new Program();
            int[] arr = new int[6] {12, 4, 2, 10, 5, 1 };
            int n = arr.Length;
            int sum = 16;

            sa.subArraySum(arr, n, sum);
        }
    }
}
