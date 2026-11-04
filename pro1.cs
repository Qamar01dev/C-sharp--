using System;

namespace CsharpVS
{
    internal class pro1
    {
        public static void Run()
        {
            Console.WriteLine("Enter number for a:");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Please enter a valid number.");
                return;
            }

            Console.WriteLine("Enter number for b:");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Please enter a valid number.");
                return;
            }

            Console.WriteLine($"Sum is {a + b}");
            Console.WriteLine($"Product is {a * b}");
            Console.WriteLine(b == 0 ? "Cannot divide by zero." : $"Division is {(double)a / b}");
            Console.WriteLine($"Minus is {a - b}");
            Console.WriteLine($"Bitwise AND is {a & b}");
        }
    }
}

