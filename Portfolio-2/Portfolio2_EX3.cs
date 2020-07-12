using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// File: Portfolio2_EX3.cs
/// Author: Jordan McCann
/// Student Number: 23571144
/// Date modified: 04/10/2018
/// </summary>

namespace _23571144_Exercise3
{
    class Portfolio2_EX3
    {
        static void Main(string[] args)
        {
            // Prompts the user and stores input for the program to use.
            Console.WriteLine("Enter the maximum number of lines of *, your number must be odd:");
            int num_stars = Convert.ToInt32(Console.ReadLine());

            // Inline conditional statement - Ternary to check if the user's entered number is odd
            bool isOdd = (num_stars % 2 == 1) ? true : false;
            if (isOdd == true) // If the number is odd, build the pyramid
            {
                Console.WriteLine(num_stars + " is Odd");
                int space, star, iter;
                // Loops for each layer / number of stars the user inputted
                for (iter = 0; iter <= num_stars; iter++)
                {
                    // Loops for space between 
                    for (space = 0; space <= (num_stars - iter); space++)
                        Console.Write(" "); // single blank space

                    // Loops and prints each star layer
                    // Starts at one as [0] 1 2 3 4 5, starting at 0 will cause an extra layer to be outputted.
                    for (star = 1; star <= iter; star++)
                        Console.Write("* "); // additional space beside the star for padding

                    // Seperates each layer output, making the pyramid clearer to see
                    // Rather than printing all of the stars in a single row to the console window
                    Console.WriteLine();
                }
            }
            else // if the number is not odd, then prompt the user and exit the program
                Console.WriteLine(num_stars + " is not odd");
        }
    }
}
