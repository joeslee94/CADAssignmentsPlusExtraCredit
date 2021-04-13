using System;
using System.Collections.Generic;
using System.Text;

namespace LabCh17GenericStack.Stacks
{
    class CowWhaleStack
    {
        //fields
        //private Animal _cow = new Cow();
        //private Animal _whale = new Whale();
        private Animal[] _animalStack;
        private int _size;
        private int _topOfStack;

        //Constructor
        public CowWhaleStack(int size)
        {
            _size = size;
            _animalStack = new Animal[size];
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
        public string Push(Animal animal)
        {
            string whichAnimalOrFull = "";
            
            if (_topOfStack <= _size)
            {
                animal = _animalStack[_topOfStack];
                _topOfStack++;
                whichAnimalOrFull = WhichAnimal(animal);
            }
            else
                whichAnimalOrFull = "Stack is full";

            return whichAnimalOrFull;
        }
        //Pop
        public (Animal animal, string whichAnimal) Pop()
        {
            Animal animal;
            string whichAnimal = "";

            if (_topOfStack > 0)
            {
                _topOfStack--;
                animal = _animalStack[_topOfStack];
                whichAnimal = WhichAnimal(animal);
            }
            
            return (_animalStack[_topOfStack], whichAnimal);
        }
        //What is the thing being returned
        private string WhichAnimal(Animal animal)
        {
            string whichAnimal = "";
            if (animal is Cow)
            {
                whichAnimal = "It's a cow!";
            }
            if (animal is Whale)
            {
                whichAnimal = "It's a whake!";
            }
            return whichAnimal;
        }
    }
}
