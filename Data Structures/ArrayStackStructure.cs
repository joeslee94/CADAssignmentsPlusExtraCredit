using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    class ArrayStackStructure<T> : IEnumerable<T>
    {
        private T[] _genArray;
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public ArrayStackStructure()
        {
            const int defaultSize = 10;
            _genArray = new T[defaultSize];
        }

        public ArrayStackStructure(int capacity)
        {
            _genArray = new T[capacity];
        }

        public void Push(T genVal)
        {
            if (_genArray.Length == Count)
            {
                T[] doubleGenArray = new T[Count * 2];
                Array.Copy(_genArray, doubleGenArray, Count);
                _genArray = doubleGenArray;
            }

            //_genArray[Count] = genVal;
            //Count++;
            
            _genArray[Count++] = genVal;
        }

        public T Pop()
        {
            if(IsEmpty)
            {
                throw new Exception("Stack is empty");
            }

            //Make a generic item hold the top item within the stack
            T poppedItem = _genArray[Count - 1];

            ////make the position at Count in stack the default value
            //_genArray[Count] = default(T);
            ////decrement Count
            //Count--;
            _genArray[Count--] = default(T);

            return poppedItem;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack is empty");
            }

            return _genArray[Count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return _genArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
