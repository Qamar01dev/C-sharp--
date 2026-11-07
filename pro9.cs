using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CsharpVS
{
    internal class pro9
    {
        private string title;
        private string place;
        private float rating;
        private double salary;
        public pro9(string title, string place, float rating, double salary)
        {
            this.title = title;
            this.place = place;
            this.rating = rating;
            this.salary = salary;

        }
        public void displayinfo()
        {
            Console.WriteLine($"title : {title} \nplace : {place}\nrating : {rating}\nsalary : {salary} ");

        }
        
        public static void Run()
        {

            pro9 game = new pro9("luna ", "islamabad ", 5.0f, 40000.0);
            game.displayinfo();
            Console.ReadLine();
        }
    }
}
