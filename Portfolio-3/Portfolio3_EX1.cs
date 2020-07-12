using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Jordan McCann
/// Student ID: 23571144
/// File: _23571144_EX1.cs
/// </summary>

namespace _23571144_Exercise1
{
    class _23571144_EX1
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
            student_data student1, student2; // Two declared student_data variables - not initialized
            populateStruct(out student1, "Mark", "Anderson", 1, "BSc (Hons) Computing", "G401"); // Initializes student1 struct
            printStudent(student1); // Prints out the data that was passed to the student1 struct
            populateStruct(out student2, "Ardhendu", "Behera", 2, "BSc (Hons) Web Design and Development", "W4D7"); // Initializes student2 struct
            printStudent(student2); // Prints out the data that was passed to the student2 struct
        }

        // Print function - formats and prints the student data fields
        static void printStudent(student_data student)
        {
            Console.WriteLine("Name: " + student.forename + " " + student.surname);
            Console.WriteLine("Id: " + student.id_number);
            Console.WriteLine("Av grade: " + student.averageGrade);
            Console.WriteLine("Programme title: " + student.programme_title);
            Console.WriteLine("Programme code: " + student.programme_code);
        }
    }
}
