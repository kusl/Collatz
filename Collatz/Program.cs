using System;
using System.Collections.Generic;
using System.Numerics;

namespace Collatz
{
    class Program
    {
        static void Main()
        {
            // BigInteger represents an aribtrarily large number, it has no upper bound.
            // This allows you to continue no matter how many steps it takes to reach a value of 1.
            Dictionary<ulong, BigInteger> dictionary = new Dictionary<ulong, BigInteger>();
            for (ulong input = 1; input < ulong.MaxValue; input++)
            {
                // No need to write a full line.
                // Separate responsibility, output from main and let the Collatz method focus on the conjecture work.
                Console.Write($"Calculating {input}: ");

                // Store the result in a BigInteger
                BigInteger result = Collatz(input);
                dictionary.Add(input, result);

                // Write your count and complete the line with a break.
                Console.Write($"{result}\n");
            }
            Console.ReadKey();
        }
        static BigInteger Collatz(ulong input)
        {
            // It's better to modify a local variable than your incoming one if you need to retain the original value.
            BigInteger value = input;

            // See the notes about BigInteger above.
            BigInteger counter = 0;
            while (value > 1)
            {
                counter++;
                if (value % 2 == 0)
                    value /= 2;
                else
                    value = 3 * value + 1;
            }

            return counter;
        }
    }
}
