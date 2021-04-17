using System;

namespace Arrays
{
    class ArrayLesson
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        private static void MakingArrays()
        {
            //1D Array
            int[] arrayOne = new int[10];
            int[] arrayTwo = { 1, 2, 3, 4, 5 };
            
            //for loop to iterate through each element
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                Console.WriteLine(arrayTwo[i]);
            }

            //foreach loop to iterate through each element
            foreach (int num in arrayTwo)
            {
                Console.WriteLine(num);
            }

            //2D Array
            int[,] twoDArrOne = new int[2, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            int[,] twoDArrTwo = { { 1, 2 }, { 4, 5 } };

            //2D Arrays SINCE YOU KNOW THE LENGTH of each array AND the length of the 2D array
            //you can just insert those numbers
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(twoDArrOne[i, j]);
                }
            }

            //Jagged Array
            int[][] jagArrOne =
            {
                new int[] {1, 2, 3, 4},
                new int[] {5, 6, 7},
                new int[] {8, 9},
                new int[] {10}
            };

            //Accessing Jagged Array
            for (int i = 0; i < jagArrOne.Length; i++)
            {
                for (int j = 0; j < jagArrOne[i].Length; j++)
                {
                    Console.WriteLine(jagArrOne[i][j]);
                }
            }
        }
    }
}
