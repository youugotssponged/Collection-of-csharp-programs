using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23571144_Exercise3
{
    class Portfolio3_EX3
    {
        // Student Data structure containing student related information
        public struct student_data
        {
            public string forename; // Student's first name field
            public string surname; // ^ ^ last name field

            // struct amended - Programme title, programme code added
            public string programme_title; // programme title e.g. Web Design and Development
            public string programme_code; // programme code e.g. CIS2147

            public int id_number; // Student ID
            public float averageGrade; // Student average grade score
        }

        // populateStruct function - amended to include programme_title and programme_code parameters.
        // takes an uninitialized struct and populates each field based on parameters inputted
        static void populateStruct(out student_data student, string fname, string surname, int id_number, string programme_title, string programme_code)
        {
            // Sets the relevant data field in relation to parameter input
            student.forename = fname;
            student.surname = surname;
            student.id_number = id_number;
            student.averageGrade = 0.0F;
            student.programme_title = programme_title;
            student.programme_code = programme_code;
        }

        // Program entry point
        static void Main(string[] args)
        {
            // Prompt and store input from the user
            Console.WriteLine("Enter the number of students:");
            int input = Convert.ToInt32(Console.ReadLine());

            // Dynamically allocate an array based on the user's input
            student_data[] students = new student_data[input];

            // For every element that has been specified 
            for(int i = 0; i < students.Length; i++)
            {
                // Prompt and store name input
                Console.WriteLine("Person " + (i + 1) + ", please enter your name:");
                string u_name = Console.ReadLine(); // locally store

                // Prompt and store surname input
                Console.WriteLine("Person " + (i + 1) + ", please enter your surname:");
                string u_lname = Console.ReadLine(); // locally store

                // Prompt and store id input
                Console.WriteLine("Person " + (i + 1) + ", please enter your ID number:");
                int u_id = Convert.ToInt32(Console.ReadLine()); // locally store

                // Prompt and store programme title input
                Console.WriteLine("Person " + (i + 1) + ", please enter your Programme Title:");
                string u_pTitle = Console.ReadLine(); // locally store

                // Prompt and store name input
                Console.WriteLine("Person " + (i + 1) + ", please enter your Programme Code:");
                string u_pCode = Console.ReadLine(); // locally store

                Console.WriteLine();

                // initialise struct with inputs given from the user for this iteration
                populateStruct(out students[i], u_name, u_lname, u_id, u_pTitle, u_pCode);
            }

            // Print every student's data out to the console
            printAllStudent(ref students);
        }

        // Print function - formats and prints the student data fields
        static void printAllStudent(ref student_data[] students)
        {
            // For every student
            for (int i = 0; i < students.Length; i++)
            {
                // Print out each data field within the student_data
                Console.WriteLine("Name: " + students[i].forename + " " + students[i].surname);
                Console.WriteLine("Id: " + students[i].id_number);
                Console.WriteLine("Av grade: " + students[i].averageGrade);
                Console.WriteLine("Programme title: " + students[i].programme_title);
                Console.WriteLine("Programme code: " + students[i].programme_code);
                Console.WriteLine();
            }
        }
    }
}
