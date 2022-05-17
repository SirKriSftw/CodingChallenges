using System;

namespace StackMin
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyStack object
            MyStack myStack = new MyStack();
            // Random object for getting random numbers to push
            Random rand = new Random();

            #region Variables for getting user input
            int stackSize = 0;
            int rangeMin = 0;
            int rangeMax = 0;
            bool canProceed = false;
            #endregion

            #region Stack Size input w/ validation
            while(!canProceed)
            {
                Console.Write("Stack Size: ");
                string inputSize = Console.ReadLine();
                bool isNum = int.TryParse(inputSize, out stackSize);
                if(isNum)
                {
                    if(stackSize <= 0)
                    {
                        Console.Write("\nEnter a valid size (greater than 0)\n");
                    }
                    else
                    {
                        canProceed = true;
                    }
                }
                else
                {
                    Console.Write("\nStack Size must be a number\n");
                }
            }
            #endregion

            #region Stack Range input w/ validation
            canProceed = false;
            while(!canProceed)
            {
                Console.Write("Range Min: ");
                string inputRange = Console.ReadLine();
                bool isNum = int.TryParse(inputRange, out rangeMin);
                if(isNum)
                {
                    Console.Write("Range Max: ");
                    inputRange = Console.ReadLine();
                    isNum = int.TryParse(inputRange, out rangeMax);
                    if (isNum)
                    {
                        if(rangeMin > rangeMax)
                        {
                            Console.Write("\nRange min cannot be greater than range max\n");
                        }
                        else
                        {
                            canProceed = true;
                        }                        
                    }
                    else
                    {
                        Console.Write("\nRange max must be a number\n");
                    }
                }
                else
                {
                    Console.Write("\nRange min must be a number\n");
                }
            }
            #endregion

            #region Push into stack and print pushed, stack and min
            for(int i = 0; i < stackSize; i++)
            {
                myStack.push(rand.Next(rangeMin,rangeMax+1));
                Console.WriteLine("\nPushed: " + myStack.peek());
                myStack.print();
                Console.WriteLine("Current min: " + myStack.min());                                
            }
            #endregion

            #region Pop from stack and print popped, stack, and min
            for(int i = 0; i < stackSize; i++)
            {
                Console.WriteLine("\nPopped: " + myStack.pop());
                
                if (i != stackSize - 1)
                {
                    myStack.print();
                    Console.WriteLine("Current min: " + myStack.min());
                }
                else
                {
                    Console.WriteLine("Stack emptied");
                }
            }
            #endregion
        }
    }
}
