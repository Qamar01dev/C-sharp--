using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CsharpVS.com.student_managment
{
    internal class Studentpro13
    {
        public int age;
        public int marks;
        public string name;
        public void detail()
        {
            Console.WriteLine($"name = {name} , age = {age} , marks = {marks}");
        }

    }
}
