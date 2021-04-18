using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    class LinkedListStackStructure<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;
        public Node<T> Next { get; set; }
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public void Push(T genVal)
        {
            if (IsEmpty)
            {
                Node<T> firstNodeToAdd = new Node<T>(genVal);
                Head = Tail = firstNodeToAdd;
            }
            else
            {
                Node<T> nodeToAdd = new Node<T>(genVal);
                Tail.next = nodeToAdd;
                Tail = nodeToAdd;
            }

            Count++;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack is empty");
            }

            Node<T> nodeToPop;

            if (Count == 1)
            {
                nodeToPop = Head;
                Head = Tail = null;
            }
            else
            {
                nodeToPop = Tail;

                Node<T> nodePointer = Head;

                for (int i = 0; i < Count-2; i++)
                {
                    nodePointer = nodePointer.next;
                }

                Tail = nodePointer;
                nodePointer.next = null;
                
                Count--;
            }
            
            return nodeToPop.val;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack is empty");
            }

            return Tail.val;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> currentNode = Head;
            while(currentNode != null)
            {
                yield return currentNode.val;
                currentNode = currentNode.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
