using System;
using System.Collections.Generic;
using System.Linq;

namespace SumLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> a = new LinkedList<int>();
            LinkedList<int> b = new LinkedList<int>();
            LinkedList<int> output = new LinkedList<int>();
            MyList myList = new MyList();
            a.AddLast(1);
            a.AddLast(2);
            a.AddLast(3);
            b.AddLast(4);
            b.AddLast(5);
            b.AddLast(6);
            output = myList.sumLists(a, b);
            for(int i = 0; i < output.Count; i++)
            {
                if( i != output.Count - 1)
                    Console.Write("[" + output.ElementAt(i) + "] -> ");
                else
                    Console.Write("[" + output.ElementAt(i) + "] = ");
            }
            Console.WriteLine(myList.convertToNum(output));
        }
    }
}
