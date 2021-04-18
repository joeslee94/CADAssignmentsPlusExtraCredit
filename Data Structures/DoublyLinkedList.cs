using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListsDoubleLinked
{
    class DoublyLinkedList
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; private set; }
        
         public void AddToFront(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            //Can be used when empty or not empty
            
            //saving value of head if there is a head
            Node<T> previousHead = Head;

            //setting the Head to the node that is passed in
            Head = node;

            //setting the previously saved head to the new Head's next
            Head.next = previousHead;

            //incrementing Count
            Count++;
            
            if (Count == 1)
            {
                Tail = Head;
            }
            else
            {
                previousHead.previous = Head;
            }
        }

        public void AddToEnd(T value)
        {
            AddLast(new Node<T>(value));
        }

        private void AddLast(Node<T> node)
        {
            if (Count == 0)
            {
                Head = node;
                //Tail = node;
            }
            else
            {
                Tail.next = node; //oldTail.next is the new node being passed in
                node.previous = Tail; //the previous node to the node is now the Tail so we need to set a link
                //Tail = node; //move the tail pointer to the node
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

            //set Head to the element next to it
            Head = Head.next;
            
            Count--;

            if (Count == 0)
            {
                Tail = null;
            }
            else
            {
                //disconnect link to old Head node
                Head.previous = null;
            }
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
                Node<T> secondToLast = Tail.previous;
                secondToLast.next = null;
                Tail = secondToLast;
            }

            Count--;
        }
    }
}
