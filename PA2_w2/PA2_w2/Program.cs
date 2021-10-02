using System;
namespace EquationSolver {
    class Program {
        static void Main() {

            Console.Write("Enter coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            QuadraticEquation quadEqn = new QuadraticEquation(a, b, c);   // instantiate quadratic eq'n
            quadEqn.PrintRoots();                                         // display results


        }
    }
    public class QuadraticEquation {

        private double a, b, c;

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

        public Boolean RealRoots() {
            
            double discriminant = b * b - (4 * a * c);

            if (discriminant >= 0)  return true;

            else                    return false;
        }
    }
}