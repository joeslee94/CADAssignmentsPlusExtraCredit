using System;
using System.Collections.Generic;
using System.Text;

namespace LabCh17GenericStack
{
    class StringStack
    {
        //   F i e l d s   &   P r o p e r t i e s

        private int _size;       // initially 0
        private string[] _stack;      // initially null
        private int _topOfStack; // initially 0


        //   C o n s t r u c t o r s

        public StringStack(int size)
        {
            _size = size;
            _stack = new string[size];
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

        public string Pop()
        {
            _topOfStack--;
            return _stack[_topOfStack];
        }

        public void Push(string valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack] = valueToPush;
                _topOfStack++;
            }
        }
    }
}
