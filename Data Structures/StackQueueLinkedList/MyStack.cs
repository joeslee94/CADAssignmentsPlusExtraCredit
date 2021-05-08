using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StackQueueLinkedList
{
    //array
    class MyStack<T> : IEnumerable<T>
    {
        private int _size;
        private T[] _stack;
        private int _count;
        public MyStack(int aSize)
        {
            _size = aSize;
            _stack = new T[_size];
        }

        public T Pop()
        {
            T genToPop;

            if(_count == 0)
            {
                throw new Exception("There are no elements in the stack to pop.");
            }
            else
            {
                _count--;
                genToPop = _stack[_count];
            }

            return genToPop;
        }

        public void Push(T aValue)
        {
            if (_count == _size - 1)
            {
                T[] doubleSize = new T[_size * 2];
                Array.Copy(_stack, doubleSize, _size);
                _stack = doubleSize;
            }
            
            _stack[_count] = aValue;
            _count++;
            
        }

        public T Peek()
        {
            T genToPeek;

            if (_count == 0)
            {
                throw new Exception("There are no elements in the stack to peek.");
            }
            else
            {
                _count--;
                genToPeek = _stack[_count];
                _count++;
            }

            return genToPeek;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                yield return _stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
