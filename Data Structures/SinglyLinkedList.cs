using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListsSingleLinked
{
    class SinglyLinkedList
    {
        public GenTNode<T> Head { get; set; }
        public GenTNode<T> Tail { get; set; }

        public int Count { get; private set; }

        public void AddToFront(T value)
        {
            AddFirst(new GenTNode<T>(value));
        }

        private void AddFirst(GenTNode<T> node)
        {
            //Can be used when empty or not empty

            GenTNode<T> nodeContainer = Head;

            Head = node;

            Head.next = nodeContainer;
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddToEnd(T value)
        {
            AddLast(new GenTNode<T>(value));
        }

        private void AddLast(GenTNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
                //Tail = node;
            }
            else
            {
                Tail.next = node;
                //Tail = node;
            }
            
            Tail = node;
            
            Count++;
        }

        public void RemoveFirst()
        {
            if (Count == 0)
            {
                throw new Exception("There are no nodes to remove");
            }

            Head = Head.next;

            if (Count == 1)
            {
                Tail = null;
            }

            Count--;
        }

        public void RemoveLast()
        {
            if (Count == 0)
            {
                throw new Exception("There are no nodes to remove");
            }

            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                //find penultimate node
                var pointerNode = Head;
                
                while(pointerNode.next != Tail)
                {
                    pointerNode = pointerNode.next;
                }

                //LOOP BREAKS when we are at the second to last element
                //So we need to set the next node to null
                Tail = pointerNode;
                pointerNode.next = null;
            }

            Count--;
        }
    }
}
