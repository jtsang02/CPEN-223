﻿//Student name:     Josiah Tsang
//Student number:   74191248

using System;

namespace Lab8 {
    public class Lab8 {
        static void Main () {
            //You could mainly use unit tests for testing.       
        }
    }
    public class Calculus {
        // Delegate for any function whose definite integral or derivative we want to calculate
        public delegate double Function (double x);

        /// <summary>
        /// Finds the definite integral of f between a and b using 
        /// the rectangular method for a given n (sub-intervals).
        /// </summary>
        /// <param name="f">A delegate representing the function f.</param>
        /// <param name="a">Lower limit of the integral.</param>
        /// <param name="b">upper limit of the integral.</param>
        /// <param name="n">The number of subintervals between a and b for the rectangular method.</param>
        /// <returns>Returns the calculated integral value.</returns>
        /// <exception cref="ArgumentException">
        /// thrown if n is not a positive number.
        /// </exception>
        public static double RectangularMethod (Function f, double a, double b, int n) {

            if (n <= 0)
                throw new ArgumentException("n must be positive");

            double sum = 0;
            double h = (b - a) / n;
            for (int i = 0; i < n; i++)
                sum += f(a + h * i);

            return h * sum;
        }

        /// <summary>
        /// Finds the definite integral adaptively by starting from 
        /// a seed value for n (# of sub-intervals), until the desired
        /// accuracy is achieved.
        /// This method uses RectangularMethod() in its implementation.
        /// </summary>
        /// <param name="f">A delegate representing the function f.</param>
        /// <param name="a">Lower limit of the integral.</param>
        /// <param name="b">upper limit of the integral.</param>
        /// <param name="SeedForN">The starting (seed) n for the rectangular method.</param>
        /// <param name="epsilon">The desired accuracy.</param>
        /// <returns>Returns the calculated integral value. 
        /// If an acceptable result is not found, returns double.NaN.</returns>
        ///<exception cref="ArgumentException">
        /// thrown if epsilon is not a positive number.
        /// </exception>
        public static double AdaptiveRectangularMethod (Function f, double a, double b, int SeedForN, double epsilon) {

            if (epsilon <= 0)
                throw new ArgumentException("epsilon must be positive");

            int n0 = SeedForN;
            int n1 = n0 * 2;
            int maxIteration = 10;

            for (int iteration = 0; iteration < maxIteration; iteration++) {
                if (Math.Abs(RectangularMethod(f, a, b, n0) - RectangularMethod(f, a, b, n1)) < epsilon)
                    return RectangularMethod(f, a, b, n1);
                else {
                    n0 *= 2;
                    n1 = n0 * 2;
                }
            }

            return double.NaN;
        }

        /// <summary>
        /// Finds the derivative of f() at the given x.
        /// </summary>
        /// <param name="f">A delegate representing the function f.</param>
        /// <param name="x">The point at which to calculate the derivative.</param>
        /// <param name="h">The h used for the central difference method.</param>
        /// <returns>Returns the calculated derivative value. </returns>
        public static double CentralDifferenceDerivative (Function f, double x, double h) {
            
            return (f(x - 2 * h) - 8 * f(x - h) + 8 * f(x + h) - f(x + 2 * h)) / (12 * h);
        }
    }
}