using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StackQueueLinkedList
{
    class MyQueue<T> : IEnumerable<T>
    {
        private int _head;
        private int _count;
        private int _size;
        private T[] _queue;

        public MyQueue(int aSize)
        {
            _size = aSize;
            _queue = new T[_size];
            _head = 0;
            _count = 0;
        }

        //Enqueue
        public void Enqueue(T aValue)
        {
            if(_count == _size - 1)
            {
                T[] doubleArray = new T[_size * 2];
                Array.Copy(_queue, doubleArray, _size);
                _queue = doubleArray;
            }

            _queue[_count] = aValue;
            _count++;
        }
        //Dequeue
        public T Dequeue()
        {
            if(_count == 0)
            {
                throw new Exception("There are no elements to dequeue");
            }

            T genToDQ = _queue[_head];
            _head++;
            return genToDQ;
        }

        //Peek
        public T Peek()
        {
            if (_count == 0)
            {
                throw new Exception("There are no elements to dequeue");
            }

            T genToPeek = _queue[_head];
            return genToPeek;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _head; i < _count; i++)
            {
                yield return _queue[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
