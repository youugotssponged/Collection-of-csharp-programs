using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Jordan McCann
/// Student ID: 23571144
/// File: _23571144_EX2.cs
/// </summary>

namespace _23571144_Exercise2
{
    class Portfolio3_EX2
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
            // Allocate a 4 element student_data array
            student_data[] students = new student_data[4];

            // Populate each element with information on each student
            populateStruct(out students[0], "Mark", "Anderson", 1, "BSc (Hons) Computing", "G401");
            populateStruct(out students[1], "Ardhendu", "Behera", 2, "BSc (Hons) Web Design and Development", "W4D7");
            populateStruct(out students[2], "Tom", "Jones", 3, "BSc (Hons) Software Engineering", "II33");
            populateStruct(out students[3], "Ewan", "Evans", 4, "BSc (Hons) Computing Games Programming", "I610");

            // Print every student's data out to the console
            printAllStudent(ref students);
        }

        // Print function - formats and prints the student data fields
        static void printAllStudent(ref student_data[] students)
        {
            // For every student
            for(int i = 0; i < students.Length; i++)
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
