using System;
using System.Text;
using System.Threading.Tasks;
namespace CsharpVS
{
    internal class pro6
    {
        public static void Run()
        {
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter operation (+ , - , / , *) : ");
            string operation = Console.ReadLine();
            while(operation != "exit")
            {
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"Sum: {firstNumber + secondNumber}");
                        break;
                    case "-":
                        Console.WriteLine($"subtraction : {firstNumber - secondNumber}");
                        break;
                    case "*":
                        Console.WriteLine($"multi: {firstNumber * secondNumber}");
                        break;
                    case "/":
                        if (secondNumber != 0)
                            Console.WriteLine($"division is : {firstNumber / secondNumber}");
                        else
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please enter +, -, *, / or 'exit' to quit.");
                        break;
                }
                operation = Console.ReadLine();
            }
            }
    }
}
