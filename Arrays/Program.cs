using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[10];
            Console.WriteLine("Enter 10 elements");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("----------------------");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Names {i} = {names[i]}");
            }

        }
    }
}
