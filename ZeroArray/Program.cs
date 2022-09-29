using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroArray
{
    public class StartZero
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8] { 2, 10, 0, 5, 3, 0, 4, 1 };


            //Move zeros to beginning
            //int count = arr.Length - 1;
            //for (int i=count; i>=0; i--)
            //{
            //    if (arr[i]!= 0)
            //    {
            //        arr[count] = arr[i];
            //        count--;
            //    }
            //}
            //while (count >= 0)
            //{
            //    arr[count]=0;
            //    count--;
            //}


            //Move zeros to end
            int count = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i]!=0)
                {
                    arr[count] = arr[i];
                    count++;
                }
            }
            while(count<arr.Length)
            {
                arr[count] = 0;
                count++;
            }
            for (int i=0; i<arr.Length; i++)
            {
                Console.WriteLine($" {arr[i]} ");
            }
        }
    }
}
