using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideArray
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int mid = (arr.Length + 1) / 2;
            int[] firstHalf = new int[mid];
            int[] secondHalf = new int[arr.Length - mid];
            Array.Copy(arr, 0, firstHalf, 0, mid);
            Array.Copy(arr, mid, secondHalf, 0, secondHalf.Length);

            Console.WriteLine(String.Join(", ", secondHalf));
            Console.WriteLine(String.Join(", ", firstHalf));        
                 
            
            
        }
    }
}
