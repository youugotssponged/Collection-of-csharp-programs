using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCann_J_23571144_Portfolio_1
{
    class Portfolio1_EX1
    {
        static void Main(string[] args)
        {
            string s1, s2; // Declare two empty string variables to store user input

            // Prompt the user to input data and 
            // store them into the newly declared variables s1 and s2
            Console.WriteLine("Enter value 1:");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter value 2:");
            s2 = Console.ReadLine();
            
            //Enter values are stored as string NOT integer
            Console.WriteLine("The entered values are" + s1 + " and " + s2);
            
            //Convert them to integer and print the sum
            int i1, i2;

            // Convert the two strings and store them as integers, 
            // that can be used for calculation.
            i1 = Convert.ToInt32(s1);
            i2 = Convert.ToInt32(s2);

            // Print the final output sum
            Console.WriteLine("The sum is: " + i1 + i2);
        }
    }
}
