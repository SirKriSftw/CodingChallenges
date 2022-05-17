using System;
using System.Collections.Generic;

namespace StackMin
{
    class MyStack
    {
        // Actual stack of numbers
        Stack<int> myStack = new Stack<int>();
        // Stack to keep track of the minimum
        Stack<int> minStack = new Stack<int>();

        /*
            A method used to add items to myStack
        */
        public void push(int a)
        {
            // Call normal push stack call
            myStack.Push(a);

            // IF this is the first item
            if(myStack.Count == 1)
            {
                // Push into min stack
                minStack.Push(a);
            }

            else
            {
                // IF pushed num is <= current minimum
                    // = part is important in case of repeating numbers
                    // IE stack: 1 | 2 | 1, when first 1 pops, second 1 is still min
                if(a <= minStack.Peek())
                {
                    // Push into min stack
                    minStack.Push(a);
                }

            }
        }

        /*
            A method used to remove top item from stack and return its value
        */
        public int pop()
        {
            // Call normal stack pop
            int popped = myStack.Pop();

            // IF poppped number is == the top of the minStack, that means it is current stack
            if(popped == minStack.Peek())
            {
                // So also remove it from minStack to update current min
                minStack.Pop();
            }
            return popped;
        }

        /*
            A method used to get the current min for MyStack
        */
        public int min()
        {
            // Returns top of minStack which contains the current min
            return minStack.Peek();
        }

        /*
            Helper method to see top of MyStack
        */
        public int peek()
        {
            return myStack.Peek();
        }

        /*
            Helper method to print out the current stack by converting it into an array
        */
        public void print()
        {
            int[] displayArray = myStack.ToArray();
            Console.Write("Currently in stack: [");
            for(int i = 0; i < myStack.Count; i++)
            {
                if(i != myStack.Count - 1)
                    Console.Write(" " + displayArray[i] + " |");
                else
                    Console.Write(" " + displayArray[i] + " ]\n");
            }
        }
    }
}
