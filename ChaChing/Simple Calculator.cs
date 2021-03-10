using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number: ");
            double first = int.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            double second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter in an operator: ");
            string operation = Console.ReadLine().ToLower();

            Console.WriteLine($"For the operator you typed in {operation}");

            double result;

            switch (operation)
            //is operation equal to the case presented
            {
                case "+":
                case "add":
                    result = first + second;
                    Console.WriteLine($"Your result is {result}.");
                    break;

                case "-":
                case "sub":
                    result = first - second;
                    Console.WriteLine($"Your result is {result}.");
                    break;

                case "*":
                case "mul":
                    result = first * second;
                    Console.WriteLine($"Your result is {result}.");
                    break;

                case "/":
                case "div":
                    result = first / second;
                    Console.WriteLine($"Your result is {result}.");
                    break;

               default:
                    Console.WriteLine("Unknown operator.");
                    break;
            }


            if (operation == "+" || operation == "add")
            {
                result = first + second;
                Console.WriteLine($"Your result is {result}.");
            }
            else if (operation == "-" || operation == "sub")
            {
                result = first - second;
                Console.WriteLine($"Your result is {result}.");
            }
            else if (operation == "*" || operation == "mul")
            {
                result = first * second;
                Console.WriteLine($"Your result is {result}.");
            }
            else if (operation == "/" || operation == "div")
            {
                result = first / second;
                Console.WriteLine($"Your result is {result}.");
            }
            else
            {
                Console.WriteLine($"Your input of {operation} is unknown.");
            }


        }
    }
}
