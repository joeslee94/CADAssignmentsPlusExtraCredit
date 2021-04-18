using System;
using System.Collections.Generic;

namespace ListsRegSingleDouble
{
    class ListsReg
    {
        static void Main(string[] args)
        {
        }

        static void GenList()
        {
            List<int> intList = new List<int>(); //integer list
            List<string> stringList = new List<string>(); //string list
            //Count and Capactiy are different things
            //Count = number of elements in the list
            //Capacity is the size of the List
            //90% or less of capacity used, we can use list.TrimExcess(); which will resize it back down to the smallest COUNT of elements

            //Sort with primitive is ascending
            //Sort with lambda we can define how to sort the list

            //List is backed up by an array internally
            //Add, Remove, RemoveAt, Reverse, ToArray, Contains, IndexOf O(N)
            //Sort O(nlogn)
            
        }

       static void CountElementsInList(List<int> intList)
        {
            Console.WriteLine($"{intList.Capacity} Capacity {intList.Count} Count");
        }
    }
}
