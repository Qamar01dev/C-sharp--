using CsharpVS.com.student_managment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpVS.com.student_managment;
namespace CsharpVS

{
    internal class Program
    {
       public static void Run()
        {
            Studentpro13 std = new com.student_managment.Studentpro13();
            std.name = "ali";
            std.age = 43;
            std.marks = 55;
            std.detail();
        }
    }    
}
