using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// File: Portfolio2_EX1.cs
/// Author: Jordan McCann
/// Student Number: 23571144
/// Date modified: 04/10/2018
/// </summary>

namespace _253571144_Exercise1
{
    class Portfolio2_EX1
    {
        static void Main(string[] args)
        {
            // Prompt the User for input
            Console.WriteLine("Enter a number to check ODD or EVEN:");

            // Recieve and store input
            int input_num = Convert.ToInt32(Console.ReadLine());

            // Checks if the remainder after division is equal to one,
            // if so, then it's odd
            if (input_num % 2 == 1)
            {
                Console.WriteLine(input_num + " is an ODD number");
            }
            // Checks if the remainder after division is equal to two, if so then is even.
            else if (input_num % 2 == 0)
            {
                Console.WriteLine(input_num + " is an EVEN number");
            }
        }
    }
}
