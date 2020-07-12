using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// File: Portfolio2_EX4.cs
/// Author: Jordan McCann
/// Student Number: 23571144
/// Date modified: 07/10/2018
/// </summary>

namespace _23571144_Exercise4
{
    class Portfolio2_EX4
    {
        static void Main(string[] args)
        {
            // Prompt and gain input from the user
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            // To store the capitalised sentence, initialised as empty.
            string capital_Sentence = "";

            Console.WriteLine("Upper case string:");

            char[] lower = { // Character array structure containing the lowercase alphabet
                'a', 'b', 'c',
                'd', 'e', 'f',
                'g', 'h', 'i',
                'j', 'k', 'l',
                'm', 'n', 'o',
                'p', 'q', 'r',
                's', 't', 'u',
                'v', 'w', 'x',
                'y', 'z', ' '
            };

            char[] upper = { // Character array structure containing the uppercase alphabet
                'A', 'B', 'C',
                'D', 'E', 'F',
                'G', 'H', 'I',
                'J', 'K', 'L',
                'M', 'N', 'O',
                'P', 'Q', 'R',
                'S', 'T', 'U',
                'V', 'W', 'X',
                'Y', 'Z', ' '
            };

            // For every letter in the user's sentence
            for (int i = 0; i < sentence.Length; i++) // Loop through each letter
            {
                for(int j = 0; j < lower.Length; j++) // Loop through each lower case alphabet
                {
                    if (sentence[i] == lower[j]) // check if theyre the same
                    {
                        capital_Sentence += upper[j]; // append letter
                    }
                    else if(sentence[i] == upper[j]) // Check if a single letter is already capitalized
                    {
                        capital_Sentence += sentence[i]; // Insert the capital letter from the original sentence into the new string
                    }
                }
            }

            // Output the fully capitalised sentence
            Console.WriteLine(capital_Sentence);
        }
    }
}
