//Student name:     Josiah Tsang
//Student number:   74191248

using System;

namespace Lab7 {
    public class Lab7 {

        static void Main () {
            //You could mainly use unit tests for testing.       
        }

    }
    public class RootFinding {
        // Delegate for any function whose root we want to find
        public delegate double Function (double x);

        /// <summary>
        /// Finds a root of f() using the Bisection method.
        /// The cap for the # of attempted iterations is 300.
        /// </summary>
        /// <param name="f">A delegate representing the function f to find the root of.</param>
        /// <param name="a">Left side of (a, b) that brackets a root.</param>
        /// <param name="b">Right side of (a, b) that brackets a root. b is greater than a. </param>
        /// <param name="epsilon">The desired accuracy.</param>
        /// <returns>Returns the calculated root. If a root cannot be found, double.NaN is returned.</returns>
        /// <exception cref="ArgumentException">
        /// thrown if f(a)*f(b) is not negative or 
        ///           epsilon is negative. 
        /// </exception>
        public static double Bisection (Function f, double a, double b, double epsilon) {

            if (f(a) * f(b) > 0 || epsilon < 0)
                throw new ArgumentException("a and b do not bracket a root, or epsilon is negative");

            int cap = 300;
            for (var i = 0; i < cap; i++) {
                if (Math.Abs(f((a + b) / 2)) < epsilon)
                    return (a + b) / 2;
                else {
                    if (f(a) * f((a + b) / 2) < 0)
                        b = (a + b) / 2;
                    else
                        a = (a + b) / 2;
                }
            }
            return double.NaN;
        }

        /// <summary>
        /// Finds a root of f() using the Secant method.
        /// </summary>
        /// <param name="f">A delegate representing the function f to find the root of.</param>
        /// <param name="x0">Initial guess x0.</param>
        /// <param name="x1">Initial guess x1 where x1 is greater than x0. </param>
        /// <param name="epsilon">The desired accuracy.</param>
        /// <returns>Returns the calculated root. If a root cannot be found, double.NaN is returned. 
        ///          (note that since there is no cap for iterations, you cannot check if a root is found or not) 
        ///</returns>
        /// <exception cref="ArgumentException">
        /// thrown if x1 is not greater than x0 or 
        ///        epsilon is negative.
        /// </exception>
        public static double Secant (Function f, double x0, double x1, double epsilon) {

            if (x1 < x0 || epsilon < 0)
                throw new ArgumentException("x1 is less than x0, or epsilon is negative");

            while (Math.Abs(x1 - x0) > epsilon) {
                double x = x1 - f(x1) * ((x1 - x0) / (f(x1) - f(x0)));
                if (Math.Abs(x - x1) < epsilon)
                    return x;

                x0 = x1;
                x1 = x;
            }
            return double.NaN;
        }
    }
}