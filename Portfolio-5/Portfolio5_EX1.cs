using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Jordan McCann
/// Student ID: 23571144
/// File: Portfolio5_EX1.cs
/// </summary>

namespace _23571144_Exercise1_
{
    //Class MyNode to hold one integer item
    //Left child leftChild 
    //Right child rightChild
    //Parent myParent (for root node myParent is NULL

    class MyNode
    {
        public int item;
        public MyNode leftChild;
        public MyNode rightChild;


        //Default Constructor
        public MyNode()
        {
            item = 0;
            leftChild = null;
            rightChild = null;
        }
        //Constructor with value parameter
        public MyNode(int value)
        {
            item = value;
            leftChild = null;
            rightChild = null;
        }
    }
    class MyBinaryTree
    {
        private MyNode root;

        //Default Constructor
        public MyBinaryTree()
        {
            root = null;
        }
        public MyNode ReturnRoot()
        {
            return root;
        }
        public void InsertNode(int id)
        {
            MyNode newNode = new MyNode(id);

            if (root == null)
            {
                //First element and it should be the root
                root = newNode;
            }
            else
            {
                //Assign the new node to the appropriate parent by comparing the item.
                //For example, if the given item is less then root's item then it goes to leftChild 
                //else go to the rightChild. Continue until you find a situation where
                //the new node could be attached as one of the child of a parent.
                //Don't foget to assign the parent node as well.
                MyNode current = root; // Pointing to the root
                while (true)
                {
                    //Add your code for building Binary tree
                    if (newNode.item <= current.item) // if less than the currently pointed to item
                    {
                        // assign new node to the empty left child if already empty
                        if (current.leftChild == null)
                        {
                            current.leftChild = newNode;
                            break;
                        }
                        // go left
                        else
                            current = current.leftChild; // re-assign / move the pointer to the left child
                    }
                    else if (newNode.item > current.item)
                    {
                        // go right
                        if (current.rightChild == null)
                        {
                            current.rightChild = newNode;
                            break;
                        }
                        else
                            current = current.rightChild; // re-assign / move the pointer to the left child
                    }

                }
            }
        }

        //NOTE: USE RECURSION FOR ALL THE BELOW TRAVERSAL ALGORITHM
        public void Preorder(MyNode tmpNode)
        {
            if (tmpNode == null)
                return;
            else
            {
                //Add your code for Pre-order traversal
                //Look at the lecture slides for pseudocode
                Console.WriteLine(tmpNode.item);
                Preorder(tmpNode.leftChild);
                Preorder(tmpNode.rightChild);
            }
        }
        public void Inorder(MyNode tmpNode)
        {
            if (tmpNode == null)
                return;
            else
            {
                //Add your code for In-order traversal
                //Look at the lecture slides for pseudocode
                Inorder(tmpNode.leftChild);
                Console.WriteLine(tmpNode.item);
                Inorder(tmpNode.rightChild);
            }
        }
        public void Postorder(MyNode tmpNode)
        {
            //Start from the Root
            if (tmpNode == null)
                return;
            else
            {
                //Add your code for Post-order traversal
                //Look at the lecture slides for pseudocode
                Postorder(tmpNode.leftChild);
                Postorder(tmpNode.rightChild);
                Console.WriteLine(tmpNode.item);
            }
        }



    }

    class Portfolio5_EX1
    {
        static void Main(string[] args)
        {
            MyBinaryTree theTree = new MyBinaryTree();
            //Insert the following number to the tree and keep the order
            //25,15,26,13,22,30,20,23,28,33,16,17
            /*   ADD YOUR CODE HERE */

            theTree.InsertNode(23); // root
            theTree.InsertNode(15);
            theTree.InsertNode(26);
            theTree.InsertNode(13);
            theTree.InsertNode(22);
            theTree.InsertNode(30);
            theTree.InsertNode(20);
            theTree.InsertNode(23);
            theTree.InsertNode(28);
            theTree.InsertNode(33);
            theTree.InsertNode(16);
            theTree.InsertNode(17);

            //Do In-order traversal of this tree and print the items
            /*   ADD YOUR CODE HERE */
            Console.WriteLine("Traversing In-order...");
            theTree.Inorder(theTree.ReturnRoot());
            Console.WriteLine();
            //Do Pre-order traversal of this tree and print the items
            /*   ADD YOUR CODE HERE */
            Console.WriteLine("Traversing Pre-Order...");
            theTree.Preorder(theTree.ReturnRoot());
            Console.WriteLine();
            //Do Post-order traversal of this tree and print the items
            /*   ADD YOUR CODE HERE */
            Console.WriteLine("Traversing Post-order...");
            theTree.Postorder(theTree.ReturnRoot());
            Console.WriteLine();
        }
    }
}
