using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCann_J_23571133_Portfolio1_EX2
{
    class Portfolio1_EX2
    {
        static void Main(string[] args)
        {
            // String based variable declaration to store data
            string forename;
            string lastname;

            // Promp the user and gain input, store to forename variable
            Console.WriteLine("Please enter your name: ");
            forename = Console.ReadLine();

            // Promp the user and gain input, store to lastname variable
            Console.WriteLine("Please enter your surname: ");
            lastname = Console.ReadLine();

            // Output the combined result with the user's full name
            Console.WriteLine("Your name is: " + forename + " " + lastname);

        }
    }
}
