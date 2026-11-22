using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CsharpVS
{
    internal class pro11
    {
        class student
        {
            public string name;
            public int no;
            public string place;
            public void detail()
            {
                Console.WriteLine($"name = {name} , no = {no} , place = {place}");
            }
        }

      public static void Run()
        {
            student info = new student();
            info.name = "hassan";
            info.no = 34;
            info.place = "pesh";
            info.detail();
                
        }
    }
}
