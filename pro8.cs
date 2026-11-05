using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CsharpVS
{
    internal class pro8
    {
        public static void Run()
        {
            Console.WriteLine("making while loop");
            int power = 8;
            int number = 7;
            int index = 1;
            while(index <= power)
            {
                BigInteger answer = BigInteger.Pow(number, index);
                Console.WriteLine($"{number}^{index} = {answer}");
                index++;
            }
        }
    }
}
