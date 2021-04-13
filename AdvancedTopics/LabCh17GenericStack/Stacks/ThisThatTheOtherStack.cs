using LabCh17GenericStack.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabCh17GenericStack.Stacks
{
    class ThisThatTheOtherStack
    {
        //Fields
        //private Thing _theOtherThing = new TheOther();
        //private Thing _thatThing = new That();
        //private Thing _thisThing = new This();

        private Thing[] _thingsStack;
        private int _size;
        private int _topOfStack;

        //Constructor
        public ThisThatTheOtherStack(int size)
        {
            _size = size;
            _thingsStack = new Thing[size];
        }

        //Methods
        //IsEmpty
        public bool IsEmpty()
        {
            if (_topOfStack == 0)
            {
                return true;
            }
            else
                return false;
        }
        //IsFull
        public bool IsFull()
        {
            if (_topOfStack >= _size)
            {
                return true;
            }
            else return false;
        }
        //Push
        public string Push(Thing thing)
        {
            string whichThingOrFull = "";
            if (_topOfStack <= _size)
            {
                thing = _thingsStack[_topOfStack];
                _topOfStack++;
                whichThingOrFull = whichThing(thing);
            }
            else
                whichThingOrFull = "Stack is full!";

            return whichThingOrFull;
        }

        //Pop
        public (Thing thing, string whichThing) Pop()
        {
            Thing thing;
            string whichThingOrEmpty = "";

            if (_topOfStack > 0)
            {
                _topOfStack--;
                thing = _thingsStack[_topOfStack];
                whichThingOrEmpty = whichThing(thing);
            }
            else
                whichThingOrEmpty = "Empty Stack!";

            return (_thingsStack[_topOfStack], whichThingOrEmpty);
        }

        private string whichThing(Thing thing)
        {
            string whichThing = "";
            if (thing is TheOther)
            {
                whichThing = "It's TheOther thing.";
            }
            else if (thing is That)
            {
                whichThing = "It's That thing.";
            }
            else if (thing is This)
            {
                whichThing = "It's This thing.";
            }
            else
                whichThing = "Did you choose a thing?";
            return whichThing;
        }
    }
}
