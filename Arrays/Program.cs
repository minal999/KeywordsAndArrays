using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[5] {"laila","kajal","mina","naina","heena"};
            string[] abc = new string[5];
            Console.WriteLine("Enter 5 elements");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] = Console.ReadLine();
            //}
            //Console.WriteLine("----------------------");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine($"Names {i} = {names[i]}");
            //}
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("----------------------");
            //Console.WriteLine("sorted array");
            //Array.Sort(names);
            //Array.Reverse(names);
            //Array.Clear(names, 2, 2);
            //Array.Copy(names, 1, abc, 0, 3);
            //Array.Copy(names, abc, names.Length);
            int index = Array.IndexOf(names, "naina");
            Console.WriteLine($"index of naina is {index}");
            foreach ( var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
