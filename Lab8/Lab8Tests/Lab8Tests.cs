//Student name:     Josiah Tsang
//Student number:   74191248

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab8.Tests {
    [TestClass()]
    public class CalculusTests {
        //Put a helper method below for each of the f(x) that you have a test case on
        //Each of these helper methods must take one parameter (type double) and must have a double return type
        double TestFunction1 (double x) //a linear function
        {
            return x + 2;
        }
        double TestFunction2 (double x) //the cos(x) - x^3 function
        {
            return Math.Cos(x) - x * x * x;
        }

        [TestMethod()]
        public void DefiniteIntegralTest1 () {
            int n = 500;
            double a = 0;
            double b = 1;

            double result = Calculus.RectangularMethod(TestFunction1, a, b, n);
            Assert.AreEqual(2.5, result, 0.01);
        }

        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentException))]
        public void DefiniteIntegralTest2 () {
            Calculus.RectangularMethod(TestFunction2, 0, 1, 0);
        }

        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentException))]
        public void DefiniteIntegralTest3 () {
            Calculus.AdaptiveRectangularMethod(TestFunction2, 0, 1, 0, 0);
        }

        [TestMethod()]
        public void DefiniteIntegralTest4 () {
            int seed = 5;
            double a = 0;
            double b = 1;
            double eps = 0.001;

            double result = Calculus.AdaptiveRectangularMethod(TestFunction1, a, b, seed, eps);
            Assert.AreEqual(2.50, result, 0.001);
        }

        [TestMethod()]
        public void DefiniteIntegralTest5 () {
            int seed = 7;
            double a = 0;
            double b = 1;
            double eps = 0.001;

            double result = Calculus.AdaptiveRectangularMethod(TestFunction2, a, b, seed, eps);
            Assert.AreEqual(0.59147, result, 0.001);
        }

        [TestMethod()]
        public void NumericalDifferentiationTest1 () {
            double x = 3;
            double h = 1;

            double result = Calculus.CentralDifferenceDerivative(TestFunction1, x, h);
            Assert.AreEqual(1, result, 0.001);
        }

        [TestMethod()]
        public void NumericalDifferentiationTest2 () {
            double x = 2;
            double h = 1;

            double result = Calculus.CentralDifferenceDerivative(TestFunction2, x, h);
            Assert.AreEqual(-Math.Sin(x) - 3 * Math.Pow(x, 2), result, 0.1);
        }

    }
}