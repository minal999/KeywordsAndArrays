using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Remove
    {
        int i = 0;
        int pos = 0;
        int[] arr = new int[5];
        public void AddArray()
        {
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public void delete()
            { 
            Console.Write("Enter position to delete item : ");
            pos = int.Parse(Console.ReadLine());

            for (i = pos - 1; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }



            Console.WriteLine("Array elements after deletion : ");
            for (i = 0; i < arr.Length-1; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr[i]);
            }

            Console.WriteLine();
        }
    }
}

