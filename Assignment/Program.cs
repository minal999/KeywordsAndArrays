using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Course[] course =
            //{
            //    new Course{CourseId=1,Name="Java",Fees=50000},
            //    new Course{CourseId=2,Name="Android",Fees=59000},
            //    new Course{CourseId=3,Name="C#",Fees=80000},
            //    new Course{CourseId=4,Name="Python",Fees=72000},
            //};
            //foreach(Course c1 in course)
            //{
            //    Console.WriteLine(c1);
            //}

            //Department[] department =
            //{
            //    new Department{Id=1,Name="Manager",Location="Pune"},
            //    new Department{Id=2,Name="Developer",Location="Delhi"},
            //    new Department{Id=3,Name="Tester",Location="Nagpur"},
            //    new Department{Id=4,Name="Adminstration",Location="Chennai"},
            //    new Department{Id=5,Name="Accounts",Location="Mumbai"}
            //};
            //foreach(Department d1 in department)
            //{
            //    Console.WriteLine(d1);
            //}

            //MaxOfArray max=new MaxOfArray();
            //Console.WriteLine("Maximum of array is "+ max.maximum());

            //MinOfArray min = new MinOfArray();
            //Console.WriteLine("Minimum of an array is " +min.minimum());

            //Duplicate duplicate = new Duplicate();
            //duplicate.find();

            Remove remove = new Remove();
            remove.AddArray();
            remove.delete();

        }
    }
}



