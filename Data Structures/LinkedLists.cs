using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _21MAR21_Noelle
{
    class Node
    {
        public int value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            this.value = value;
            this.Next = null;
        }

        //we need a way to manage the link between nodes
        //NODE's purpose is to hold the value and know its neighbors address
        //Another class, a different concept, to manage the nodes
    }

    class LinkedList
    {
        public Node Head { get; set; }
        public LinkedList()
        {
            this.Head = null;
        }
        public int GetValueAtIndex(int index) //takes the node at the index and then provides the value stored on the node
        {
            //Initialize an integer for setting the value at Index
            int valueAtIndex = 0;
            //have to find the index of the node
            Node runner = this.Head;
            //however, we cannot just index the nodes directly because we did not put an index value

            //if index == 0 what happens?
            if (index < 0)
            {
                throw new Exception("Enter a valid index");
            }
            else if (index == 0)
            {
                return runner.value;
            }
            else
            {
                //a for loop will give us that index given the int value it will iterate through/until
                //iterator is i++
                for (int i = 1; i <= index; i++)
                {
                    //STARTS at HEAD and this statement will be 
                    runner = runner.Next;
                    //what happens when the index is larger than the length of the list
                    //what happens when the index is at the end of the list
                    if (runner.Next == null)
                    {
                        valueAtIndex = runner.value;
                    }
                }
            }

            return valueAtIndex;
        } 
        public void AddValuetoNodeANDNodetoEnd(int value) //Adding value to the node and adding the node to the linkd list
        {
            //have to create a new node no matter what
            Node newNode = new Node(value); //Nodes value is set here

            //if the head is null, set the head, which is a node, to the value so that the head references the node with the inputted value
                //WE DO NOT WANT TO CHANGE THE HEAD
            if (this.Head == null)
            {
                this.Head = newNode;
                return; //makes the head into the new node that is created
            }

            //CREATE A TEMP VARIABLE that is a pointer that iterates to the last node. this is evaluated when the runner says its next is null
            Node runner = this.Head;
            while (runner.Next != null)
            {
                runner = runner.Next;
            }

            //update the last node's next to point to the newly created node.
            runner.Next = newNode;
        } 
        public void AddtoFront(int value)
        {
            //Must create a new node to add to the head
            Node newHead = new Node(value);
            //Make a new node
            
            //this.Head.Next = placeHolderNode; //O(head/placeholder) --> O(head)--O(placeHolder)
            //this.Head = newHead; //O(newHead)--O(placeHolder)
            
            //Creating a node holding the Head of the linked list
            Node placeHolderNode = this.Head; //do not need this
            //point new node to the current Head
            //update the head 
            //O(Head) no value means O(newHead) becomes O(Head)
            if (this.Head == null)
            {
                this.Head = newHead; //making th eHead the node that was created
            }
            else
            {
                this.Head.Next = placeHolderNode; //O(head/placeholder) --> O(head)--O(placeHolder)
                this.Head = newHead; //O(newHead)--O(placeHolder)
            }
        }
        public int RemoveAt(int index)
        {
            //have to find the index of the node
            Node runner = this.Head;
            //however, we cannot just index the nodes directly because we did not put an index value
            
            //if index == 0 what happens?
            if (index == 0)
            {
                this.Head = runner.Next;
                return runner.value;
            }

            //a for loop will give us that index given the int value it will iterate through/until
            //within the for loop we need the runner to equal the runner.Next?
            //length is set to index
            //iterator is i++
            for (int i = 0; i < index - 1; i++)
            {
                runner = runner.Next;
                //what happens when the index is larger than the length of the list
                //what happens when the index is at the end of the list
                if (runner.Next == null)
                {
                    throw new Exception("The is not a valid index.");
                }
            }

            //THE NEXT runner.NEXT = is the item to remove
            //runner is at the node before the node we want to skip
            //nodeToRemove is going to be runner.Next
            Node nodeToChange = runner.Next;
            //nodeToRemove.Next is the node I want the runner to link with
            //runner.Next = nodetoremove.Next?
            runner.Next = nodeToChange.Next;
            return nodeToChange.value;
        }
        public int UpdateAt(int index, int value)
        {
            //Initialize an integer for setting the value at Index
            int valueAtIndexBeforeUpdate = 0;
            //have to find the index of the node
            Node runner = this.Head;
            //however, we cannot just index the nodes directly because we did not put an index value

            //if index == 0 what happens?
            if (index < 0)
            {
                throw new Exception("Enter a valid index");
            }
            else if (index == 0)
            {
                valueAtIndexBeforeUpdate = runner.value;
                runner.value = value;
                return valueAtIndexBeforeUpdate;
            }
            else
            {
                //a for loop will give us that index given the int value it will iterate through/until
                //iterator is i++
                for (int i = 1; i <= index; i++)
                {
                    runner = runner.Next;
                    if (i == index - 1)
                    {
                        valueAtIndexBeforeUpdate = runner.value;
                        runner.value = value;
                    }
                    else
                        continue;
                }
            }

            return valueAtIndexBeforeUpdate;
        }

    }
}
