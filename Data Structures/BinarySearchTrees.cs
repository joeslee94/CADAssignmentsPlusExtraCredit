using System;
using System.Collections.Generic;
using System.Text;

namespace _28MAR21_Noelle_Notes
{
    //we need a node class
    class Node
    {
        //property
        public int value { get; set; }
        public Node leftChild { get; set; }
        public Node rightChild { get; set; }

        //constructor
        public Node(int value)
        {
            this.value = value;
            this.rightChild = null;
            this.leftChild = null;
        }

    }

    //a tree has root and has children
    //a BINARY tree has a root/node and has no more than 2 children
    //BINARY SEARCH TREE -- sorting it in a way to make the search easier What we are using
    //There are standard rules
    //Left is less than
    //Right is greater than equal to
    //Left and right adds have conditions and then
    //IF asked hey find x number in array, we have to touch each number O(n)
    //IN binary search tree we only need to go through the conditions of the tree O(log n)

    class BinarySearchTrees
    {
        public Node root { get; set; }

        public BinarySearchTrees(int value)
        {
            root.value = value;
            root.rightChild = null;
            root.leftChild = null;
        }

        public void Add(int value)
        {
            //create node
            Node newNode = new Node(value);

            //if root is null this becomes the null
            if (this.root == null)
            {
                this.root = newNode;
            }
            else
            {
                Node leftOrRightPointer = this.root;
                bool addedSuccesful = false; //did not add node yet //makes it explicit

                while (!addedSuccesful) //WHILE we have not added the node //CAN BE input as true
                {
                    if (newNode.value < leftOrRightPointer.value) // && leftOrRight.leftChild == null) //easier to break up
                    {
                        if (leftOrRightPointer.leftChild == null) //ask one question at a time! is the left null?
                        {
                            leftOrRightPointer.leftChild = newNode; //we have added the node
                            addedSuccesful = true; //change to true //can either break (out of the loop) or return (out of the method)
                        }
                        else
                        {
                            leftOrRightPointer = leftOrRightPointer.leftChild;
                        }
                    }
                    else //(leftOrRight.value <= newNode.value)// && leftOrRight.rightChild == null)
                    {
                        if (leftOrRightPointer.rightChild == null)
                        {
                            leftOrRightPointer.rightChild = newNode;
                            addedSuccesful = true;
                        }
                        else
                        {
                            leftOrRightPointer = leftOrRightPointer.rightChild;
                        }
                    }
                }
            }
        }

        //FIND
        public Node Find(int value)
        {
            //Node findValue = new Node(value);
            //string message = "";
            Node leftOrRightPointer = this.root;
            if (this.root == null)
            {
                throw new Exception("There are no nodes with valid values for you to find.");
            }
            else
            {
                //int leftturn = 0;
                //int rightturn = 0;
                while(leftOrRightPointer.value != value)
                {
                    if (leftOrRightPointer.value == value)
                    {
                        //message += "The Node with the specified value is the root.";
                        return leftOrRightPointer;
                    }
                    
                    //left of root or node is less than
                    if (value < leftOrRightPointer.value && leftOrRightPointer.leftChild != null)
                    {
                        leftOrRightPointer = leftOrRightPointer.leftChild;
                        //leftturn++;
                        if (leftOrRightPointer.value == value)
                        {
                            return leftOrRightPointer;
                        }
                        else
                            continue;

                    }

                    //right is greater than or equal to
                    if (value >= leftOrRightPointer.value && leftOrRightPointer.rightChild != null)
                    {
                        leftOrRightPointer = leftOrRightPointer.rightChild;
                        //rightturn++;
                        if (leftOrRightPointer.value == value)
                        {
                            return leftOrRightPointer;
                        }
                        else
                            continue;
                    }
                }

                //message += $"After going left {leftturn} times and right {rightturn} times, your Node with the specified value was found.";
            }
            return leftOrRightPointer;
        }
        public void Remove(int value)
        {
            //trickiest = remove node WHAT ABOUT THE KIDS THINK OF THEM AND HOW TO LINK THEM
            //WHAT if we remove the root??
            //Node compareValue = new Node(value);
            
            if (this.root == null)
            {
                throw new Exception("You do not have a node with a value to remove.");
            }
            else
            {

                if (this.root.value == value)
                {
                    Node originalRootHolder = this.root;
                    Node nodeRight = originalRootHolder.rightChild; //OG root right
                    //Node nodeLeft = originalRootHolder.leftChild; // OG root left
                    Node pointer = nodeRight;
                    //I want to find on the right side of the original tree where the pointer.left can be put on.
                    pointer = pointer.leftChild;
                    //holding onto the left child of the OG root's right child
                    int lessThanPointer = pointer.value - 1;
                    Node whereToAddPointer = Find(lessThanPointer);
                    whereToAddPointer.leftChild = pointer;

                    //made the left node of the OG's right node null then took the OG left null and equated it to the OG's right Node's left
                    nodeRight.leftChild = null;
                    nodeRight.leftChild = originalRootHolder.leftChild;

                    //made the OG's right node the root
                    this.root = nodeRight;
                }

                Node nodeToRemove = Find(value);
                Node orphanRight = nodeToRemove.rightChild;
                Node orphanLeft = nodeToRemove.leftChild;

                Node newParentforOrphanRight = Find(orphanRight.value - 1); //but we need to find a node with a null
                Node newParentforOrphanLeft = Find(orphanLeft.value + 1); //but we need to find a node with a null
            }
        }

    }
}
