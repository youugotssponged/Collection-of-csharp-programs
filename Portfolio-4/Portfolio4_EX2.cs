using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Jordan McCann
/// Student ID: 23571144
/// File: Portfolio4_EX2.cs
/// </summary>

namespace _23571144_Exercise2
{
    class MyDoublyLinkedList
    {
        private string name;
        public MyDoublyLinkedList next;
        public MyDoublyLinkedList prev;


        //Default Constructor
        public MyDoublyLinkedList()
        {
            name = "";
            next = null;
            prev = null;
        }
        //Constructor with parameter
        public MyDoublyLinkedList(string value)
        {
            name = value;
            next = null;
            prev = null;
        }

        //Insert a new node with a value AFTER the current node
        public void InsertNextNode(MyDoublyLinkedList current, string value)
        {
            MyDoublyLinkedList node = new MyDoublyLinkedList(value);
            if (current.next == null)
            {
                //Insert at the end and easy to handle
                current.next = node;
                node.prev = current;
            }
            else
            {
                //Insert in the middle               
                node.next = current.next; // update the new node's next pointer to now be current -> next
                node.prev = current; // update the new node's prev to point to current
                current.next.prev = node; // update the next node's prev to point to the new node as it has been sloted in before it
                current.next = node; // current node now points to the new node
          
            }
        }

        //Insert a new node with a value BEFORE the current node
        public void InsertPrevtNode(MyDoublyLinkedList current, string value)
        {
            MyDoublyLinkedList node = new MyDoublyLinkedList(value);
            if (current.prev == null)
            {
                //Insert in the beginning 
                node.next = current; // inserts before the beginning, making the new node at the beginnin
            }
            else
            {
                //Insert in the middle               
                current.prev = node;
                node.next = current;
                prev.next = node;
                node.prev = prev;
            }
        }
        public void DeleteNode()
        {
            //Check for ERROR if you are deleting a node which is referred by many pointers.
            //Update all these pointers before deleting (releasing) memory!

            if (next == null)//last node
            {
                //Delete the last node
                prev = null;
            }
            else if (prev == null)
            {
                //Delete head node
                next = null;
            }
            else
            {
                //Update the next node pointer and reset the deleted node to null
                next = next.next; // reassign pointer to the node that comes after the next
                next.next.prev = null; // delete the node that is previous of the newly pointed to node
            }
        }

        //Traverse forward
        public void TraverseForward(MyDoublyLinkedList node)
        {
            //Print the values stored in each node from current to tail
            Console.WriteLine("Traversing in forward direction...");
            while (node != null)//Traverse from the current node
            {
                Console.WriteLine(node.name); // Print out the current node's name that is associated with that node
                node = node.next; 
            }
        }

        //Traverse Backward
        public void TraverseBackward(MyDoublyLinkedList node)
        {
            //Print the values stored in each node from current to head
            Console.WriteLine("Traversing in backward direction...");
            while (node != null)//Traverse from the current node
            {
                Console.WriteLine(node.name); // print out that node's associated name
                node = node.prev; // update node location - go one previous
            }
        }

    }

    class Portfolio4_EX2
    {
        static void Main(string[] args)
        {
            //Create the first node
            MyDoublyLinkedList node = new MyDoublyLinkedList("Ardhendu");

            //Assign head
            MyDoublyLinkedList head = node;

            // array variable to hold each person's name to be inserted into the list
            string[] names = { "Tom", "Jones", "David", "Andrew", "Peter", "Mark", "Collette", "Dave", "Dan" };

            //Add 9 more consecutive nodes (Tom, Jones, David, Andrew, Peter, Mark, Collette, Dave, Dan)
            for (int i = 2; i <= 10; i++)
            {
                node.InsertNextNode(node, names[(i - 2)]);
                node = node.next;
            }
            //Traverse the linked list from head to tail
            node.TraverseForward(head);

            //Delete Peter node and then traverse forward
            head.next.next.next.next.DeleteNode();
            node.TraverseForward(head);

            //Insert Peter after Mark and then traverse backward
            node.InsertNextNode(head.next.next.next.next.next, "Peter");
            node.TraverseBackward(head.next.next.next.next.next.next.next.next.next);

        }
    }
}
