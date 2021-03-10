using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int firstnumber = 0;
            int secondnumber = 1;
            
            Console.WriteLine(firstnumber);
            Console.WriteLine(secondnumber);

            int numberinfor = 0;

            for (int i = 2; i < 20; i++)
            //starts the iteration at the second element because we have the 0 and 1 element above.
            {
                numberinfor = firstnumber + secondnumber;
                Console.WriteLine(numberinfor);
                firstnumber = secondnumber;
                secondnumber = numberinfor;                
            }
        }
    }
}
