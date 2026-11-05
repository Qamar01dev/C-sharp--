using System;
using System.Numerics;

namespace CsharpVS
{
    internal class pro7
    {
        public static void Run()
        {
            int power = 67;
            int number = 9;
            BigInteger answer = BigInteger.One;

            // Multiply exactly 'power' times; BigInteger prevents overflow.
            for (int index = 0; index < power; index++)
            {
                answer *= number;
            }

            Console.WriteLine($"{number}^{power} = {answer}");
        }
    }
}
