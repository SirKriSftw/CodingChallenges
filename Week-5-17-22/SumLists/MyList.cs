using System;
using System.Collections.Generic;
using System.Linq;

namespace SumLists
{
    class MyList
    {
        public LinkedList<int> sumLists(LinkedList<int> a, LinkedList<int> b)
        {
            int aNum = convertToNum(a);
            int bNum = convertToNum(b);
            int sum = aNum + bNum;
            LinkedList<int> sumList = new LinkedList<int>();
            sumList = convertToList(sum);
            return sumList;
        }

        public int convertToNum(LinkedList<int> a)
        {
            int output = 0;
            for (int i = 0; i < a.Count; i++)
            {
                output = output + (int)(a.ElementAt(i) * Math.Pow(10, i));
            }
            return output;
        }
        
        public LinkedList<int> convertToList(int a)
        {
            int digits = 0;
            int temp = a;
            LinkedList<int> output = new LinkedList<int>();

            while (temp > 0)
            {
                temp = temp / 10;
                digits++;
            }
            
            for(int i = 0; i < digits; i++)
            {
                output.AddLast((int)(a % Math.Pow(10, i+1) / Math.Pow(10,i)));
            }

            return output;
        }
    }
}
