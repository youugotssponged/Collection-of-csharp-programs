using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// File: Portfolio2_EX6.cs
/// Author: Jordan McCann
/// Student Number: 23571144
/// Date modified: 07/10/2018
/// </summary>

namespace _23571144_Exercise6
{
    class Portfolio2_EX6
    {
        static void Main(string[] args)
        {
            // Generate a random number from 1-100
            Random r = new Random(); // create a new instance of the random class
            int r_num = r.Next(100); // Generate a random number with 100 being the maximum

            // to keep track of the lives / attempts the user has left
            int attempt_count = 5;

            Console.WriteLine("A number between 1 & 100 has been generated, please take a guess.");

            // While the user still has available attempts
            while (attempt_count > 0)
            {
                // Prompt the user and gain input
                Console.Write("Guesses Remaining [" + attempt_count + "]: ");
                int user_guess = Convert.ToInt32(Console.ReadLine());

                // If guessed correctly
                if (user_guess == r_num)
                {
                    Console.WriteLine("Congratulations! You Guessed Correctly! The number was: " + r_num);
                    break; // stops the loop becoming infinite
                }

                // If guessed incorrectly
                if (user_guess != r_num)
                {
                    // Calculate the difference between the secret number and the users guess
                    int difference = r_num - user_guess;

                    // Low Decision Branch
                    if(difference > 10) // If the difference is within, 10, 20, 50 etc. print the relevant message to the user
                    {
                        if(difference >= 10)
                        {
                            if(difference >= 20)
                            {
                                if(difference >= 50)
                                {
                                    Console.WriteLine("Very Low");
                                    attempt_count--; // Deduct attempt
                                    continue; // Move to the next iteration of this loop
                                }
                                else
                                {
                                    Console.WriteLine("Low");
                                    attempt_count--;
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Moderately Low");
                                attempt_count--;
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Somewhat Low");
                            attempt_count--;
                            continue;
                        }
                    }

                    // High Decision Branch
                    if(difference <= 50)
                    {
                        if(difference < 50)
                        {
                            if(difference < 20)
                            {
                                if(difference < 10)
                                {
                                    Console.WriteLine("Somewhat High");
                                    attempt_count--;
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("Moderately High");
                                    attempt_count--;
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("High");
                                attempt_count--;
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Very High");
                            attempt_count--;
                            continue;
                        }
                    }
                }
            }

            // Check if player lost
            if (attempt_count == 0)
            {
                Console.WriteLine("The secret number was: " + r_num); // Reveal number
                Console.WriteLine("YOU LOST"); // Prompt the user
            }

        }
    }
}
