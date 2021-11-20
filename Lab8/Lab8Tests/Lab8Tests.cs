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
    }
}