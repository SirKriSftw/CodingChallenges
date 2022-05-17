using System;
using System.Collections.Generic;
using System.Linq;

namespace SumLists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region In/Out lists and my object
            LinkedList<int> a = new LinkedList<int>();
            LinkedList<int> b = new LinkedList<int>();
            LinkedList<int> output = new LinkedList<int>();
            MyList myList = new MyList();
            #endregion

            #region Adding random values to both lists and printing
            Random rand = new Random();
            int aSize = rand.Next(1, 6);
            int bSize = rand.Next(1, 6);
            for(int i = 0; i < aSize; i++)
            {
                a.AddLast(rand.Next(0,9));
            }
            for(int i = 0; i < bSize; i++)
            {
                b.AddLast(rand.Next(0,9));
            }
            
            Console.Write("\t");
            for(int i = 0; i < a.Count; i++)
            {
                if( i != a.Count - 1)
                    Console.Write("[" + a.ElementAt(i) + "] -> ");
                else
                    Console.Write("[" + a.ElementAt(i) + "]");
            }
            Console.Write("\n + \t");
            for(int i = 0; i < b.Count; i++)
            {
                if( i != b.Count - 1)
                    Console.Write("[" + b.ElementAt(i) + "] -> ");
                else
                    Console.Write("[" + b.ElementAt(i) + "]\n");
            }
            Console.WriteLine("--------------------------------");
            #endregion

            #region Sum reading from tail to head
            output = myList.sumLists(a, b);
            Console.Write("\t");
            for(int i = 0; i < output.Count; i++)
            {
                if( i != output.Count - 1)
                    Console.Write("[" + output.ElementAt(i) + "] -> ");
                else
                    Console.Write("[" + output.ElementAt(i) + "] = ");
            }
            Console.WriteLine(myList.convertToNum(output));
            #endregion

            #region Reverse order of input and printing
            LinkedList<int> copyA = a;
            LinkedList<int> copyB = b;
            a = new LinkedList<int>();
            b = new LinkedList<int>();
            for(int i = 0; i < copyA.Count; i++)
            {
                a.AddFirst(copyA.ElementAt(i));
            }
            for(int i = 0; i < copyB.Count; i++)
            {
                b.AddFirst(copyB.ElementAt(i));
            }

            Console.Write("\n\n");
            Console.Write("\t");
            for(int i = 0; i < a.Count; i++)
            {
                if( i != a.Count - 1)
                    Console.Write("[" + a.ElementAt(i) + "] -> ");
                else
                    Console.Write("[" + a.ElementAt(i) + "]");
            }
            Console.Write("\n + \t");
            for(int i = 0; i < b.Count; i++)
            {
                if( i != b.Count - 1)
                    Console.Write("[" + b.ElementAt(i) + "] -> ");
                else
                    Console.Write("[" + b.ElementAt(i) + "]\n");
            }
            Console.WriteLine("--------------------------------");
            #endregion

            #region Sum reading head to tail
            output = myList.sumListsReverse(a, b);
            Console.Write("\t");
            for(int i = 0; i < output.Count; i++)
            {
                if( i != output.Count - 1)
                    Console.Write("[" + output.ElementAt(i) + "] -> ");
                else
                    Console.Write("[" + output.ElementAt(i) + "] = ");
            }
            Console.WriteLine(myList.convertToNumReverse(output));
            #endregion
        }
    }
}
