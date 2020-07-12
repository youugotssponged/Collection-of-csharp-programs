using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Jordan McCann
/// Student ID: 23571144
/// File: Portfolio4_EX1
/// </summary>

namespace _23571144_Exercise1
{
    class MySinglyLinkedList
    {
        public int val;
        public MySinglyLinkedList next;

        //Default Constructor
        public MySinglyLinkedList()
        {
            val = 0;
            next = null;
        }
        //Constructor with parameter
        public MySinglyLinkedList(int value)
        {
            val = value;
            next = null;
        }


        //Insert a new node with a value after the current node
        public void InsertNode(MySinglyLinkedList current, int value)
        {
            MySinglyLinkedList node = new MySinglyLinkedList(value);
            if (current.next == null)
            {
                current.next = node; // Inserts the next node after the current node if there currently is none
            }
            else
            {
                // - current is the temporary node in this case
                // - node is the new node to be allocated
                
                node.next = current.next; // assigns the new node's next pointer to the current node's next
                current.next = node; // re-assigns the current node's next to point to the new node
            }
        }

        // Deletes the next node from the currently specified node
        public void DeleteNextNode(MySinglyLinkedList current)
        {
            if (current.next == null)//there is no next node, we have already reached the end
                return;
            else
            {
                // - current is the temporary node in this case
                current.next = current.next.next; // Reassign pointer to the next node's next
                next = null; // nullify / delete the next node that is to be deleted
            }
        }

        // Prints all of the node values within a given linked list
        public void TraverseList(MySinglyLinkedList node)
        {
            //Print the values stored at the each node in the list from head to tail
            Console.WriteLine("Traversing in forward direction...");
            while (node != null)//Traverse from the current node
            {
                // Print current value of the node
                Console.WriteLine(node.val); // print current node's value
                node = node.next; // move to the next node and repeat

            }
        }
    }

    class Portfolio4_EX1
    {
        static void Main(string[] args)
        {
            //Create the first node
            MySinglyLinkedList node = new MySinglyLinkedList(1);
            MySinglyLinkedList head = node; // Head - 1st node in the list
            
            //Add 9 more consecutive nodes 2-9
            for (int i = 2; i <= 10; i++)
            {
                //Add your code here
                node.InsertNode(node, i); // Insert new node
                node = node.next; // Update current node location
            }

            //Traverse the linked list from head to tail
            //Add your code here
            node.TraverseList(head);

            //Delete 3rd node and then traverse
            //Add your code here
            node.DeleteNextNode(head.next); // Start from the second node, then delete the next - which is the 3rd node in this case
            node.TraverseList(head); // Re-print out the list again to show changes

            //Insert 100 after the node value 7 and then traverse
            //Add your code here
            node.InsertNode(head.next.next.next.next.next, 100); // inserts a node after the 7th node which is marked with the value 7
            node.TraverseList(head);
        }
    }
}
