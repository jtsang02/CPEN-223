using System;
using System.Collections.Generic;

namespace PA6_w3 {

    class Program {
        static void Main() {

            List<QuadraticEquation> equationList = new List<QuadraticEquation>();

            for (int i = 1; i < 4; i++) 
                for (int j = 1; j < 4; j++)
                    equationList.Add(new QuadraticEquation(1, i, j));

            foreach (QuadraticEquation item in equationList) {

                item.PrintRoots();
                item.PrintEquation();

            }
        }
    }
    class QuadraticEquation {

        private readonly double a, b, c;

        public QuadraticEquation(double a, double b, double c) {    // constructor
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void PrintRoots() {

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

        public void PrintEquation() {

            Console.WriteLine(+ a + "x^2 + " + b + "x + " + c + " = 0 ");

        }
    }

}
