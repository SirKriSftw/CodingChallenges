using System;
using System.Collections.Generic;
using System.Linq;

namespace SumLists
{
    class MyList
    {
        #region Reading tail to head of list
        /*
            A method that takes in 2 linked lists and sums them into an output linked list
            Reading them from tail to head
        */
        public LinkedList<int> sumLists(LinkedList<int> a, LinkedList<int> b)
        {
            // First convert both lists into int
            int aNum = convertToNum(a);
            int bNum = convertToNum(b);

            // Add both numbers together
            int sum = aNum + bNum;

            // Convert sum number into a list
            LinkedList<int> sumList = new LinkedList<int>();
            sumList = convertToList(sum);

            // Return the sum in linked list form
            return sumList;
        }

        /*
            A method that converts a linked list into a number. Reads from tail to head
            IE [1] -> [2] -> [3] = 321
        */
        public int convertToNum(LinkedList<int> a)
        {
            int output = 0;
            for (int i = 0; i < a.Count; i++)
            {
                // Multiply each element by 10^index, this makes the first element in the ones place, the second in the tens and so on
                output = output + (int)(a.ElementAt(i) * Math.Pow(10, i));
            }
            // Return the sum of all the elements multipled by 10^index
            return output;
        }
        
        /*
            A method that converts an int to a linked list
            321 = [1] -> [2] -> [3]
            Read from tail to head
        */
        public LinkedList<int> convertToList(int a)
        {
            int digits = 0;
            int temp = a;
            LinkedList<int> output = new LinkedList<int>();

            // Used to find the number of digits the input number has
            while (temp > 0)
            {
                temp = temp / 10;
                digits++;
            }
            
            for(int i = 0; i < digits; i++)
            {
                // Extract each digit individually and put into list
                output.AddLast((int)(a % Math.Pow(10, i+1) / Math.Pow(10,i)));
            }

            return output;
        }
        #endregion
        #region Reading head to tail of list
        /*
            A method that takes in 2 linked lists and sums them into an output linked list
            Reading them from head to tail
        */
        public LinkedList<int> sumListsReverse(LinkedList<int> a, LinkedList<int> b)
        {
            // First convert both lists into int
            int aNum = convertToNumReverse(a);
            int bNum = convertToNumReverse(b);

            // Add both numbers together
            int sum = aNum + bNum;

            // Convert sum number into a list
            LinkedList<int> sumList = new LinkedList<int>();
            sumList = convertToListReverse(sum);

            // Return the sum in linked list form
            return sumList;
        }

        /*
            A method that converts a linked list into an int reading from head to tail
            IE [1] -> [2] -> [3] = 123
        */
        public int convertToNumReverse(LinkedList<int> a)
        {
            int output = 0;
            for (int i = 0; i < a.Count; i++)
            {
                // Multiply each number by 10^(size of list - 1 - index), makes last digit in the ones place, the 2nd to last digit in the tens place, etc.
                output = output + (int)(a.ElementAt(i) * Math.Pow(10, (a.Count-1) - i));
            }
            return output;
        }

        /*
            A method that converts an int to a linked list
            321 = [3] -> [2] -> [1]
            Read from head to tail
        */
        public LinkedList<int> convertToListReverse(int a)
        {
            int digits = 0;
            int temp = a;
            LinkedList<int> output = new LinkedList<int>();

            // Used to find the number of digits the input number has
            while (temp > 0)
            {
                temp = temp / 10;
                digits++;
            }
            
            for(int i = 0; i < digits; i++)
            {
                // Extract each digit individually and put into list, ADD FIRST to read from head to tail
                output.AddFirst((int)(a % Math.Pow(10, i+1) / Math.Pow(10,i)));
            }

            return output;
        }
        #endregion
    }
}
