using System;

namespace SortingAlgos
{
    class SortingAlgos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void BasicSwap(int[] arr, int i, int j)
        {
            if (i == j)
            {
                return;
            }
            else
            {
                (i, j) = (j, i);
            }
            //int temp = arr[i]
            //arr[i] = arr[j];
            //arr[j] = temp;
        }
        static void BubbleSort(int[] bubArr)
        {
            for (int wall = bubArr.Length - 1; wall > 0; wall--)
            {
                for (int i = 0; i < wall; i++)
                {
                    if (bubArr[i] > bubArr[i+1]) //what if I write >=? duplicate numbers will be swapped since they are equal
                    {
                        BasicSwap(bubArr, i, i + 1);
                    }
                }
            }
        }

        static void SelectionSort(int[] selArr)
        {
            for (int wall = selArr.Length; wall > 0; wall--)
            {
                int largestInt = selArr[0];
                for (int i = 1; i <= wall; i++)
                {
                    if (largestInt < selArr[i])
                    {
                        largestInt = selArr[i];
                    }
                }
                BasicSwap(selArr, largestInt, selArr[wall]);
            }
        }

        static void InsertionSort(int[] insArr)
        {
            for (int wall = 1; wall < insArr.Length; wall++)
            {
                int elementBeforeWall = insArr[wall];
                int i = 0;

                for (i = wall; i > 0 && insArr[i - 1] > elementBeforeWall; i--)
                //Reason is because i reaches index 0 and the loop resets
                {
                    insArr[i] = insArr[i - 1];
                }

                insArr[i] = elementBeforeWall;
            }
        }

        static int FactorialIterative(int num) //much faster
        {
            if (num == 0) //base case
            {
                return 1;
            }

            int factorial = 1;
            for (int i = 1; i < num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static int FactorialRecursion(int num) //much slower
        {
            if (num == 0)
            {
                return 1;
            }

            return num * FactorialRecursion(num - 1);

            //FactorialRecursion(3) = 3*FactorialRecursion(2) This function is then called again
            //FactorialRecursion(2) = 2*FactorialRecursion(1)
            //FactorialRecursion(1) = 1*FactorialRecursion(0)
            //FactorialRecursion(0) = 1
        }

        static void ShellSort(int[] sheSort)
        {
            int gap = 1;
            while (gap < sheSort.Length/3)
            {
                gap = 3 * gap + 1;
            }

            while (gap >= 1)
            {
                for (int i = gap; i < sheSort.Length; i++) //the pointer
                {
                    for (int j = i; j >= gap && sheSort[j] < sheSort[j-gap]; j -= gap) //checking if values separated by gap should be swapped
                    {
                        BasicSwap(sheSort, sheSort[j], sheSort[j - gap]);
                    }
                }

                gap /= 3;
            }
        }

        static void MergeSort(int[] merSort)
        {
            int[] aux = new int[merSort.Length];

            Sort(0, merSort.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                {
                    return;
                }
                
                int mid = (high + low) / 2;
                Sort(low, mid); //low is lower guard, mid is higher guard
                Sort(mid + 1, high);

                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                if (merSort[mid] <= merSort[mid + 1])
                    return;

                int iLow = low;
                int midPlusOne = mid + 1;

                Array.Copy(merSort, low, aux, low, high - low + 1);

                for (int k = low; k <= high; k++)
                {
                    if (iLow > mid)
                        merSort[k] = aux[midPlusOne++];
                    else if
                        (midPlusOne > high) merSort[k] = aux[iLow++];
                    else if
                        (aux[midPlusOne] < aux[iLow]) merSort[k] = aux[midPlusOne++];
                    else
                        merSort[k] = aux[iLow++];
                }
            }
        }
        static void QuickSort(int[] quiSor)
        {
            Sort(0, quiSor.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                    return;

                int middleOfSplitArr = Partition(low, high);
                Sort(low, middleOfSplitArr - 1); //left
                Sort(middleOfSplitArr + 1, high); //right
            }

            int Partition(int low, int high)
            {
                int iLow = low;
                int jHighPlusOne = high + 1;

                int pivot = quiSor[low]; //first element is the pivot
                while (true)
                {
                    while (quiSor[++iLow] < pivot)
                    {
                        if (iLow == high)
                            break;

                    }

                    while (pivot < quiSor[--jHighPlusOne])
                    {
                        if (jHighPlusOne == low)
                        {

                        }
                    }

                    if (iLow >= jHighPlusOne)
                        break;

                    BasicSwap(quiSor, quiSor[iLow], quiSor[jHighPlusOne]);
                }
                BasicSwap(quiSor, quiSor[low], quiSor[jHighPlusOne]);
                return jHighPlusOne;
            }

        }
    }
}
