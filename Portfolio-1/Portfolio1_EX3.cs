using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCann_J_23571133_Portfolio1_EX3
{
    class Portfolio1_EX3
    {
        static void Main(string[] args)
        {
            // Prompt the user to input the number of people
            Console.WriteLine("Please enter the number of people: ");

            // Store the input into a string as ReadLine returns 
            // a string that has been entered via the console
            // the variable name is prefixed with s to signify that it is a string
            string s_person_count = Console.ReadLine();

            // Convert the string result into a usable integer
            int person_count = Convert.ToInt32(s_person_count);

            // Declare two empty arrays to store the inputs from the user
            // Problem: empty primitive arrays are non expandable, must be defined
            // Error when in use, "Array out of bounds exception"
            // Debugger used to analyse where the program was throwing the exception
            //string[] first_names = new string[] { };
            //string[] last_names = new string[] { };

            // Generic List arrays can be expandable
            // Avoids the out of bounds exception

            // List documentation and explaination found at
            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.7.2

            // Declare and initialize two List objects for storing user input
            List<string> first_names = new List<string>();
            List<string> last_names = new List<string>();

            // Loop through for each number of people that the user inputted
            for (int i = 0; i < person_count; i++)
            {
                // (i + 1) has been used as List's are indexed from 0.
                // without this, the program would output "person 0" etc. 
                // which can have a negative effect on the user.

                // Prompt and add the result of the user's input into the first_names List
                Console.WriteLine("Person " + (i + 1) + ", please enter your name: ");
                first_names.Add(Console.ReadLine());

                // Prompt and add the result of the user's input into the first_names List
                Console.WriteLine("Person " + (i + 1) + ", please enter your surname: ");
                last_names.Add(Console.ReadLine());

                // Display the person's full name
                Console.WriteLine("The name of person " + (i + 1) + " is " + first_names[i] + " " + last_names[i]);
            }

        }
    }
}
