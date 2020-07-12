using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// File: Portfolio2_EX2.cs
/// Author: Jordan McCann
/// Student Number: 23571144
/// Date modified: 04/10/2018
/// </summary>


namespace _23571144_Exercise2
{
    class Portfolio2_EX2
    {
        // Helper function that checks if a number given is prime or not
        public bool checkPrime(int input)
        {
            // Cycles through each number starting from two
            // Dividing each iteration by the users input
            // Loop starts at two as 1 and 0 are not prime numbers since the number has to be greater than one

            // Simple check if the user inputs 0 or 1 as they are not prime
            if (input == 0 || input == 1)
                return false;

            for (int i = 2; i < input; i++)
            {
                // if the result is 0, the number is not prime
                // A prime number is greater than one, so 0 is ruled out
                if(input % i == 0)
                {
                    return false; // Return false, exit the function
                }
            }
            // The number given is prime
            // as it is divisible by itself and one
            return true;
        }

        static void Main(string[] args)
        {
            // Prompt the User for input and store into a variable for the program's use
            Console.WriteLine("Enter a number to check ODD or EVEN:");
            int input_num = Convert.ToInt32(Console.ReadLine());

            // Finds if a number entered by the user is Prime or Not...
            // Creates a new instance of this class to utilise the checkPrime() helper function
            Portfolio2_EX2 PrimeCheck = new Portfolio2_EX2();
            
            // Checks if the number "is" prime
            if (PrimeCheck.checkPrime(input_num) == true)
            {
                Console.WriteLine(input_num + " is PRIME");
            }
            // Checks if the number "is not" prime
            else if (PrimeCheck.checkPrime(input_num) == false)
            {
                Console.WriteLine(input_num + " is NOT PRIME");
            }

            // Checks if the remainder after division is equal to one,
            // if so, then it's odd
            if (input_num % 2 == 1)
            {
                Console.WriteLine(input_num + " is an ODD number"); // Prompt
            }
            // Checks if the remainder after division is equal to two, if so then is even.
            else if (input_num % 2 == 0)
            {
                Console.WriteLine(input_num + " is an EVEN number"); // Prompt
            }

        }
    }
}
