using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StackQueueLinkedList
{
    class Node<T>
    {
        public T val { get; set; }
        public Node<T> next { get; set; }
        
        public Node(T aVal)
        {
            val = aVal;
        }
    }
    class MyLinkedList<T> : IEnumerable<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public int nodeCounter;
        //Print all Values
        public void printAllNodes()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }
        }
        //AddFirst
        public void AddFirst(T aVal)
        {
            Node<T> toAdd = new Node<T>(aVal);
            toAdd.next = head;
            head = toAdd;
            nodeCounter++;
        }
        //AddLast
        public void AddLast(T aVal)
        {
            if(nodeCounter == 0)
            {
                head = new Node<T>(aVal);
                tail = head;
            }
            else
            {
                Node<T> toAdd = new Node<T>(aVal);
                Node<T> pointer = head;
                while(pointer.next != null)
                {
                    pointer = pointer.next;
                }
                pointer.next = new Node<T>(aVal);
                tail = pointer.next;
            }
            nodeCounter++;
        }

        //Remove Head
        public void RemoveHead()
        {
            head = head.next;
        }

        //Remove In Body
        public void RemoveInList(int position)
        {
            if(nodeCounter == 0)
            {
                throw new Exception("There are no nodes to remove");
            }

            Node<T> pointer = head;

            for (int i = 0; i < position; i++)
            {
                if(i == position - 1)
                {
                    pointer.next = pointer.next.next;
                }

                pointer = pointer.next;
            }
            nodeCounter--;
        }

        //Remove Last
        public void RemoveTail()
        {
            Node<T> pointer = head;

            while(pointer.next.next != null)
            {
                pointer = pointer.next;
            }

            pointer.next = null;
            tail = pointer;
        }

        //Reference
        public Node<T> Reference(int position)
        {
            if (nodeCounter == 0)
            {
                throw new Exception("There are no nodes to remove");
            }

            Node<T> pointer = head;

            for (int i = 0; i < position; i++)
            {
                pointer = pointer.next;
                if (pointer == tail && position != i)
                {
                   throw new Exception("There is no Node containing that value.");
                }
            }

            
            return pointer;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < nodeCounter; i++)
            {
                Node<T> pointer = head;
                yield return pointer.val;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
