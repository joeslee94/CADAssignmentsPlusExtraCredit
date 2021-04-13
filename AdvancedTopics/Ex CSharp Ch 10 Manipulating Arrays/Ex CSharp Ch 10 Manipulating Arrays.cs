using System;
using System.Collections.Generic;

namespace Ex_CSharp_Ch_10_Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 2, 4, 6, 8, 10 };
            //Console.WriteLine(Sum(a));
            //Console.WriteLine(Average(a));
            //Reverse(a);
            //Console.WriteLine(Max(a));

            int[] b = { 1, 3, 5, 7, 9 };
            //Console.WriteLine(Max(b));
            //LeftRotateArray(b, 2);
            //SortingArray(b);

            int[] c = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            //Console.WriteLine(Max(c));
            //LeftRotateArray(c, 2);
            //SortingArray(c);

            int[] d = { -6, -5, -4, -3, -2, -1 };
            //Console.WriteLine(Max(d));
            //LeftRotateArray(d, 2);
            //SortingArray(d);
        }

        static void LeftRotateArray(int[] array, int rotate)
        {
            //int[] a = { 0, 2, 4, 6, 8, 10 }; --> 2, 4, 6, 8, 0 (1x) --> 4, 6, 8, 10, 0, 2 (2x)
            //int[] holdValues = new int[rotate + 1];
            List<int> rotatedList = new List<int>(array.Length);
            //created a list
            //rotate the list two times to the left
            var holdValues = new ArraySegment<int>(array, 0, rotate);
            //holdValues = 0, 2

            for (int i = rotate ; i < array.Length; i++) //starts at index 2 which is 4
            {
                rotatedList.Add(array[i]);
                //4, 6, 8, 10
            }

            rotatedList.AddRange(holdValues); //4, 6, 8, 10, 0, 2
            int[] rotatedArr = rotatedList.ToArray(); //rotatedArr != array

            for (int i = 0; i < rotatedArr.Length; i++)
            {
                array[i] = rotatedArr[i];
            }
            //makes the array that was passed in to the rotated array

            foreach (var num in array)
            {
                Console.WriteLine(num);
            }
        }

        static int Sum(int[] array)
        {
            int sum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static double Average(int[] array)
        {
            double sum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            
            double average = sum/array.Length;
            return average;
        }

        static void Reverse(int[] array)
        {
            for (int i = 0; i <= array.Length / 2; i++)
            {
                for (int j = array.Length - 1 - i; j >= array.Length / 2; j--)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    break;
                }
            }

            foreach (var num in array)
            {
                Console.WriteLine(num);
            }
        }

        static int Max(int[] array)
        {
            int maxNum = array[0];
            
            for (int i = 0; i < array.Length-1; i++)
            {

                if (array[i] > array[i + 1])
                {
                    continue;
                }
                else
                    maxNum = array[i + 1];
            }
            
            return maxNum;
        }

        static void SortingArray(int[] array)
        {
            //doesnt seem efficient with two for loops.
            int valueHolder = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        valueHolder = array[j];
                        array[j] = array[i];
                        array[i] = valueHolder;
                    }
                }
            }
            
            foreach (var num in array)
            {
                Console.WriteLine(num);
            }
            //int valueHolder = 0;
            //while (array[0] > array[1]) The problem
            //{
            //    for (int i = 0; i < array.Length-1; i++)
            //    {
            //        // 6 5 4 3 1
            //        if (array[i] > array[i+1])
            //        {
            //            valueHolder = array[i+1];
            //            array[i + 1] = array[i];
            //            array[i] = valueHolder;
            //        }
            //    }
            //}
        }
    }
}
