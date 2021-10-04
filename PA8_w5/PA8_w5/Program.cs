using System;
using System.Collections.Generic;

namespace PA6_w3 {

    /// <summary>
    /// Contains constructor for new quadratic equation and methods to calculate and print the roots.
    /// </summary>
    class QuadraticEquation {

        private readonly double a, b, c;
        
        /// <summary>
        /// Constructor to create new object of QuadraticEquation with 3 coefficients.
        /// </summary>
        /// <param name="a">first coefficient</param>
        /// <param name="b">second coefficient</param>
        /// <param name="c">third coefficient</param>
        public QuadraticEquation (double a, double b, double c) {    // constructor
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Determines if there are real roots and either prints them to console or "displays no real roots".
        /// </summary>
        public void PrintRoots () {

            double discriminant = b * b - (4 * a * c);

            if (discriminant >= 0) {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine("The roots are: ");
                Console.WriteLine("Root1 = " + root1 + " and Root2 = " + root2);
            }
            else {
                Console.WriteLine("there are no real roots");
            }
        }

        /// <summary>
        /// Prints quadratic equation to console in the form of ax^2 + bx + c = 0.
        /// </summary>
        public void PrintEquation () {

            Console.WriteLine(+a + "x^2 + " + b + "x + " + c + " = 0 ");

        }
    }

}
