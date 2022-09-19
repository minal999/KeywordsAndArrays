using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        //static void Swap(ref int a, ref int b)
        //{
        //    int temp;
        //    temp = a;
        //    a = b;
        //    b = temp;
        //}

        //static void Calculation(int a, int b, out int sum, out int sub, out int multiply)
        //{
        //    sum = a + b;
        //    sub = a - b;
        //    multiply = a * b;
        //}

        static void AcceptNames(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("----------------------------");
        }


        static void Main(string[] args)
        {   //Ref Keyword

            //int a = 10, b = 20;
            //Swap(ref a, ref b); // call by ref / address
            //Console.WriteLine($"a = {a}  b= {b}");


            //out keyword

            //int a = 10, b = 20, sum, multiply, sub;
            //Calculation(a, b, out sum, out sub, out multiply);
            //Console.WriteLine($" sum ={sum} \n sub={sub} \n multiplication {multiply}");



            //params keyword

            AcceptNames("Rahul", "Kishor", "Tushar");
            AcceptNames("Rahul", "Kishor");
            AcceptNames("Rahul", "Kishor", "Tushar", "Raj");

        }
    }
}
