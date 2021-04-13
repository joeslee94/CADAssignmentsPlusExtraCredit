using System;
using System.Collections.Generic;
using System.Text;

namespace LabCh17GenericStack.Classes
{
    abstract class Thing
    {
        private int _items;

        public Thing()
        {

        }

        abstract public string WhatAmI();
    }
}
