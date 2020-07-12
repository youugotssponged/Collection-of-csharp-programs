using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCann_J_23571144_Portfolio1_EX4
{
    class Portfolio1_EX4
    {
        static void Main(string[] args)
        {
            // Constant variable as the value of PI does not change.
            const double PI = 3.142;

            // Declared variables to store calculation results
            double circle_area;
            double circle_perimeter;
            double circle_radius; // Used for storing user input

            // Prompt the user for the radius of the circle
            // convert and store the input to be used as a calculation
            Console.WriteLine("What is the radius of the circle?");
            circle_radius = Convert.ToDouble(Console.ReadLine());

            // Calculate the circle area
            circle_area = PI * Math.Pow(circle_radius, 2);

            // Calculate the circle perimeter
            circle_perimeter = (2 * PI) * circle_radius;

            // Output the results of calculating the users cricle area and its perimeter.
            Console.WriteLine("The area of the circle is: " + circle_area);
            Console.WriteLine("The perimeter of the circle is: " + circle_perimeter);

        }
    }
}
