using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// File: Portfolio2_EX5.cs
/// Author: Jordan McCann
/// Student Number: 23571144
/// Date modified: 07/10/2018
/// </summary>

namespace _23571144_Exercise5
{
    class Portfolio2_EX5
    {
        static void Main(string[] args)
        {
            // Prompt the user and gain input
            Console.WriteLine("Please enter a word:");
            string input = Console.ReadLine();

            // empty string, for comparison purposes
            // Will be populated with a reversed string
            // by taking and copying each letter from the input string, but in a reverse manner
            // e.g starting at the end of the sentence and working backwards.
            string reversed = "";

            // Reverse the string
            // (input.Length) - 1 as it is indexed like a char[] array,
            // Without accounting for the 0 index, causes the variable to go out of bounds when trying to access it.
            for(int i = (input.Length - 1); i >= 0; i--)
            {
                // Insert the character into the reverse variable
                // since it is going backwards, from starting at the end of the user's inputted sentence
                reversed += input[i]; // Copying from one string to the other
            }

            // check to see if it is palindrome or not
            if(reversed == input)
            {
                Console.WriteLine(input + " is a palindrome"); // If successful, prompt the user that it is palindrome
            }
            // If not, then print out a message to the user
            else
            {
                Console.WriteLine(input + " is NOT a palindrome");
            }

        }
    }
}
