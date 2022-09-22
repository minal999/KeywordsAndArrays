using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();

            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //list.Add(10);
            //list.Insert(1, 15);
            //list.IndexOf(10); // 0
            //list.LastIndexOf(10);  //3
            //list.Remove(30);
            // list.RemoveAt(0);

            //list.Sort();
            // list.Reverse();
            // list.Clear();
            //Console.WriteLine($"Capacity of list is {list.Capacity}");
            //Console.WriteLine($"Count od list is { list.Count}");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //Stack stack = new Stack();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //stack.Pop();

            //Console.WriteLine($"peek of stack is  {stack.Peek()}");

            //foreach (var item in stack)
            //    {
            //        Console.WriteLine(item);
            //    }

            //Queue q=new Queue();
            //    q.Enqueue(10);
            //    q.Enqueue(20);
            //    q.Enqueue(30);

            //    q.Dequeue();

            //    Console.WriteLine($"peek of queue is  {q.Peek()}");
            //    foreach (var item in q)
            //    {
            //        Console.WriteLine(item);
            //    }


            Hashtable ht = new Hashtable();
            ht.Add(91, "IND");
            ht.Add(1, "USA");
            ht.Add(63, "AUS");
            ht.Add(33, "FR");

            ht.Remove(1);

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine($"Country Code: {d.Key}  Country: {d.Value}");
            }
        


    }


}
    }

