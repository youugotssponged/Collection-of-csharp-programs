using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCann_J_23571144_Portfolio1_EX5
{
    class Portfolio1_EX5
    {
        static void Main(string[] args)
        {

            // Declared variables to store calculation results
            double circle_area;
            double circle_perimeter;
            double circle_radius; // Used for storing user input

            // Prompt the user for the radius of the circle
            // convert and store the input to be used as a calculation
            Console.WriteLine("What is the radius of the circle?");
            circle_radius = Convert.ToDouble(Console.ReadLine());

            // Calculate the circle area
            // Now using the PI class, accessing the _PI variable
            circle_area = PI._PI * Math.Pow(circle_radius, 2);

            // Calculate the circle perimeter
            // Now using the PI class, accessing the _PI variable
            circle_perimeter = (2 * PI._PI) * circle_radius;

            // Output the results of calculating the users cricle area and its perimeter.
            Console.WriteLine("The area of the circle is: " + circle_area);
            Console.WriteLine("The perimeter of the circle is: " + circle_perimeter);

        }
    }
}
