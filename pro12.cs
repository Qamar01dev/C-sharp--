using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpVS
{
    internal class pro12
    {
        static object std2;
        class student()
        {
           public string name;
           public int marks;
        }
        public static void Run()
        {
            student std = new pro12.student();
            std.name = "hasssssan";
            std.marks = 43;

            student std2 = std;
            std.name = "ali";
            Console.WriteLine(std.name);
        }
    }
}
