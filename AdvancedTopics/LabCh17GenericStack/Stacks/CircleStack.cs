using System;
using System.Collections.Generic;
using System.Text;

namespace LabCh17GenericStack
{
    class CircleStack
    {
        // fields
        private Circle[] _circleStack;
        private int _topOfStack;
        private int _size;

        //Constructor
        public CircleStack(int size)
        {
            _size = size;
            _circleStack = new Circle[size];
        }


        //   M e t h o d s

        public bool IsEmpty()
        {
            if (_topOfStack > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsFull()
        {
            if (_topOfStack >= _size)
            {
                return true;
            }

            return false;
        }

        public Circle Pop()
        {
            _topOfStack--;
            return _circleStack[_topOfStack];
        }

        public void Push(Circle topCircle)
        {
            if (_topOfStack < _size)
            {
                _circleStack[_topOfStack] = topCircle;
                _topOfStack++;
            }
        }
    }
}
