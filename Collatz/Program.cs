using System;
using System.Collections.Generic;

namespace Collatz
{
    class Program
    {
        static void Main()
        {
            Dictionary<UInt64, int> dictionary= new Dictionary<UInt64, int>();
            UInt64 max = UInt64.MaxValue;
            for (UInt64 input = 1; input < max; input++)
            {
                int result = Collatz(input);
                dictionary.Add(input, result);
            }
        }
        static UInt64 IfEven(UInt64 input)
        {
            return input / 2;
        }
        static UInt64 IfOdd(UInt64 input)
        {
            return 3 * input + 1;
        }
        static int Collatz(UInt64 input)
        {
            UInt64 originalInput = input;
            Console.WriteLine(input);
            int counter = 0;
            while (input > 1)
            {
                counter++;
                if (input % 2 == 0)
                {
                    input = IfEven(input);
                }
                else
                {
                    input = IfOdd(input);
                }
            }
            Console.WriteLine($"My calculation for Collatz counter for {originalInput} is {counter}.");
            return counter;
        }
    }
}
