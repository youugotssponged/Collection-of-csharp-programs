using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23571144_Exercise3
{
    public struct student_data // Student information
    {
        public string forename;
        public string surname;
        public int id_number;
        public float averageGrade;
    }

    class MySinglyLinkedList
    {
        public string student_forename; // first name
        public string student_surname; // Last name
        public int student_id_num; // id 
        public float student_AverageGrade; // average grade


        public MySinglyLinkedList next;

        //Default Constructor
        public MySinglyLinkedList()
        {
            student_forename = "";
            student_surname = "";
            student_id_num = 0;
            student_AverageGrade = 0f;

            next = null;
        }
        //Constructor with parameter
        public MySinglyLinkedList(student_data value)
        {
            // Converts the information from the student_data given into the class
            student_forename = value.forename;
            student_surname = value.surname;
            student_id_num = value.id_number;
            student_AverageGrade = value.averageGrade;

            next = null;
        }


        //Insert a new node with a value after the current node
        public void InsertNode(MySinglyLinkedList current, student_data value)
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

        // Deletes a particular node by searching for its name
        public void DeleteNodeByName(MySinglyLinkedList current, string search_fname, string search_lname)
        {
            // While not found
            while (current.next.student_forename != search_fname && current.next.student_surname != search_lname)
            {
                current = current.next; // move to the next node
            }

            // If found
            if (current.next.student_forename == search_fname && current.next.student_surname == search_lname)
            {
                var temp = current.next.next; // Reassign pointer
                current.next = null; // Delete node
                current.next = temp; // Reassign pointer
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
                Console.WriteLine("Name: " + node.student_forename + " " + node.student_surname);
                Console.WriteLine("Student ID: " + node.student_id_num);
                Console.WriteLine("Average Grade: " + node.student_AverageGrade);
                Console.WriteLine();

                node = node.next; // move to the next node and repeat

            }
        }
    }

    class Portfolio4_EX3
    {
        static void Main(string[] args)
        {
            // Initial data
            student_data student1;
            student1.forename = "Jordan";
            student1.surname = "McCann";
            student1.id_number = 23571144;
            student1.averageGrade = 79f;

            student_data student2;
            student2.forename = "Niall";
            student2.surname = "Davis";
            student2.id_number = 23572354;
            student2.averageGrade = 67f;

            student_data student3;
            student3.forename = "Steven";
            student3.surname = "Carpenter";
            student3.id_number = 23535671;
            student3.averageGrade = 85f;

            student_data student4;
            student4.forename = "Nathan";
            student4.surname = "Dew";
            student4.id_number = 23531234;
            student4.averageGrade = 99f;

            //Create the first node
            MySinglyLinkedList node = new MySinglyLinkedList(student1); // ME
            MySinglyLinkedList head = node; // Head - 1st node in the list

            // Insert two more nodes and reposition the next pointer
            node.InsertNode(node, student2); // Niall
            node = node.next;

            node.InsertNode(node, student3); // Steven
            node = node.next;

            node.InsertNode(node, student4); // Nathan
            node = node.next;

            // Traverse from head to tail
            Console.WriteLine("List before node deletion: ");
            node.TraverseList(head);
            Console.WriteLine();

            node.DeleteNodeByName(head, "Nathan", "Dew"); // Delete Node
            node.DeleteNodeByName(head, "Steven", "Carpenter"); // Delete node

            Console.WriteLine("List After Deletion: ");
            node.TraverseList(head);

        }
    }
}
