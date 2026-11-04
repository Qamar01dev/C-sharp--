using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpVS
{
    internal class pro2
    {
        public static void Run()
        {
            string mystring = "what is freaking up ";
            Console.WriteLine(mystring.Length);
            Console.WriteLine(mystring[3]);
            Console.WriteLine(mystring.IndexOf("freaking"));
            Console.WriteLine(mystring.Substring(3, 5));
            Console.WriteLine(mystring.Replace("freaking", "freakin"));
            Console.WriteLine(mystring.ToUpper());
            Console.WriteLine(mystring.ToLower());
            Console.WriteLine(mystring.Trim());

        }
    }
}

