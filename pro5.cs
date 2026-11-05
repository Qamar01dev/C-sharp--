using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CsharpVS
{
    internal class pro5
    {
        public static void Run()
        {
            Console.WriteLine("{0}, {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0}, {1}", float.MinValue, float.MaxValue);
            int i = 1;
            byte b = (byte)i;
            Console.WriteLine(b);
            var number = 55643;
            int n = Convert.ToInt32(number);
            Console.WriteLine(number);
            var num = 53;
            int clampedNum = Math.Clamp(num, (int)byte.MinValue, (int)byte.MaxValue);
            byte nu = (byte)clampedNum;
            Console.WriteLine($"num={num}, byte={nu}");
        }
    }
}
