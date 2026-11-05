using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpVS
{
    internal class pro4
    {
        public static void Run()
        {
            double mynumber = 45.43;
            Console.WriteLine(mynumber);
            double mymathnumber = mynumber / 5;
            Console.WriteLine("division is " + mymathnumber);
            Console.WriteLine("multiplication of mynumber is  " + 55.34 * mynumber);
            int menumber = 44;
            double mydouble = menumber;
            Console.WriteLine("assaining to the mydouble a value of me number");
            Console.WriteLine("also their multiplication is " + menumber * mydouble);
            Console.WriteLine("Abs "  + Math.Abs(-34 * 54));
            Console.WriteLine("Round value is " + Math.Round(45.433, 2));
            Console.WriteLine("ceiling value is " + Math.Ceiling(45.433));
            Console.WriteLine("value of floor is " + Math.Floor(45.433));
            Console.WriteLine(" max value is " + Math.Max(443.53, 44));
            Console.WriteLine("sqrt is " + Math.Sqrt(44));
            Console.WriteLine("log is " + Math.Log(4));
            Console.WriteLine("tan value is " + Math.Tan(43.44));
            Console.WriteLine("value of sin is "+Math.Sin(53));
            Console.ReadLine();
        }

    }
}
