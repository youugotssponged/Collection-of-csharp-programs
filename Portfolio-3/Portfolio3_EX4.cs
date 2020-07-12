using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Jordan McCann
/// Student ID: 23571144
/// File: _23571144_EX4.cs
/// </summary>

namespace _23571144_Exercise4
{
    class Portfolio3_EX4
    {
        // struct - student related data
        public struct student_data
        {
            public string forename; // Student's first name field
            public string surname; // Student's surname field
            public int id_number; // Student's ID field
            public float averageGrade; // Student's average grade field

            public module_data[] modules; // Student's list of modules
        }

        // Struct - module related data
        public struct module_data
        {
            public string moduleCode; // module code field
            public string moduleTitle; // module title field
            public int score; // module score field
        }

        // Populate struct function which initialises a given student_data object with data passed by the parameters
        static void populateStruct(out student_data student, string fname, string surname, int id_number, module_data[] mods)
        {
            student.forename = fname; // sets first name
            student.surname = surname; // sets surname
            student.id_number = id_number; // sets id number
            student.averageGrade = 0.0F; // sets average grade - 0.0 to begin with

            student.modules = mods; // sets the modules 
        }

        // Populate module function which initialises a given module via parameters
        static void populateModule(out module_data module, string mcode, string mname, int score)
        {
            module.moduleCode = mcode; // sets module code
            module.moduleTitle = mname; // sets module name
            module.score = score; // sets module score
        }

        static void Main(string[] args)
        {
            // Create student array
            student_data[] students = new student_data[2];

            // Create module arrays
            module_data[] student1mods = new module_data[6];
            module_data[] student2mods = new module_data[6];

            // Allocate modules
            // Student 1
            populateModule(out student1mods[0], "CIS2147", "Programming: Theroy to Practice", 96);
            populateModule(out student1mods[1], "CIS2150", "Game Engines", 70);
            populateModule(out student1mods[2], "CIS2162", "Employability", 84);
            populateModule(out student1mods[3], "CIS1111", "Programming Concepts", 65);
            populateModule(out student1mods[4], "CIS1110", "Web Design & Development", 93);
            populateModule(out student1mods[5], "CIS1109", "Computer Architecture & Networks", 77);

            // Student 2
            populateModule(out student2mods[0], "CIS2147", "Programming: Theroy to Practice", 66);
            populateModule(out student2mods[1], "CIS2150", "Game Engines", 33);
            populateModule(out student2mods[2], "CIS2162", "Employability", 55);
            populateModule(out student2mods[3], "CIS1111", "Programming Concepts", 65);
            populateModule(out student2mods[4], "CIS1110", "Web Design & Development", 83);
            populateModule(out student2mods[5], "CIS1109", "Computer Architecture & Networks", 37);

            // Create student and allocate module
            populateStruct(out students[0], "Jordan", "McCann", 1, student1mods);
            populateStruct(out students[1], "Niall", "Davis", 2, student2mods);

            // Print student information to the console
            printStudent(students[0]);
            printStudent(students[1]);

        }

        // prints student data
        static void printStudent(student_data student)
        {
            Console.WriteLine("Name: " + student.forename + " " + student.surname);
            Console.WriteLine("ID: " + student.id_number);
            Console.WriteLine("Av grade: " + student.averageGrade);
            Console.WriteLine();
        }

    }
}
