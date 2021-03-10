using System;

namespace Lab5_Monte_Carlo_Pi
{
    class Program
    {
        static void Main(string[] args)
        {
            double insidecircle = 0;
            double outsidecircle = 0;

            Console.WriteLine("Please type in the number of iterations: ");
            double iterations = double.Parse(Console.ReadLine());
            
            for (double i = 0; i <= iterations; i++)
            {
                double x = RandomXY();
                double y = RandomXY();
                double hypotenuse = Hypotenuse(x, y);

                if (hypotenuse <= 1.0)
                {
                    insidecircle++;
                }
                else
                {
                    outsidecircle++;
                }
            }

            double insideVSiterations = insidecircle / iterations;
            double piEstiamte = insideVSiterations * 4;

            Console.WriteLine($"Estimated value of Pi:{piEstiamte:N5}.\n" +
                $"Value of Pi {Math.PI:N5}.\n" +
                $"Difference between Pi and Estimate {(Math.PI - piEstiamte):N5}.");
        }

        static double RandomXY()
        {
            Random random = new Random();
            double randomnumber = random.NextDouble();
            return randomnumber;
        }

        static double Hypotenuse(double x, double y)
        {
            double hypotnuse = Math.Sqrt(x * x + y * y);
            return hypotnuse;
        }

    }
}
