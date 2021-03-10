using System;

namespace _1342._Number_of_Steps_to_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int steps = ReduceNumber(num);
            Console.WriteLine($"Number of steps to zero is {steps}");
        }

        static int ReduceNumber(int num)
        {
            int steps = 0;

            while (num > 0)
            {
                if (num % 2 != 0)
                {
                    num--;
                    steps++;
                }
                else if (num % 2 == 0)
                {
                    num = num / 2;
                    steps++;
                }
            }
            return steps;
        }
    }
}
