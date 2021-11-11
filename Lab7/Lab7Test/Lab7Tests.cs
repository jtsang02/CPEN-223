//Student name:     Josiah Tsang
//Student number:   74191248

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab7.Tests {
    [TestClass()]
    public class RootFindingTests {
        //Put a helper method below for each of the f(x) that you have a test case on
        //Each of these helper methods must take one parameter (type double) and must have a double return type
        double TestFunction1 (double x)     //  a quadratic equation
        {
            return x * x + (-3) * x + 2;
        }
        double TestFunction2 (double x)     //  the cos(x) - x^3 equation
        {
            return Math.Cos(x) - x * x * x;
        }

        double TestFunction3 (double x) {   // the x^2 − 612 equation
            return Math.Pow(x, 2) - 612;
        }

        [TestMethod()]
        public void BisectionTest1 () {
            double epsilon = 0.0001;
            double a = 0.5;
            double b = 1.5;
            double result = RootFinding.Bisection(TestFunction1, a, b, epsilon);
            Assert.AreEqual(1, result, epsilon);
        }

        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentException))]
        public void BisectionTest2 () {
            RootFinding.Bisection(TestFunction2, 0.8, 0.85, 0.0001);
        }

        [TestMethod()]
        public void BisectionTest3 () {
            double epsilon = 0.001;
            double a = 0;
            double b = 1;
            double result = RootFinding.Bisection(TestFunction2, a, b, epsilon);
            Assert.AreEqual(0.865, result, epsilon);
        }

        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentException))]
        public void BisectionTest4 () {
            RootFinding.Bisection(TestFunction2, 0.8, 0.85, -0.0001);
        }

        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentException))]
        public void SecantTest1 () {
            RootFinding.Secant(TestFunction3, 0.85, 0.8, 0.0001);
        }

        [TestMethod()]
        public void SecantTest2 () {
            double epsilon = 0.0001;
            double x0 = 10;
            double x1 = 30;
            double result = RootFinding.Secant(TestFunction3, x0, x1, epsilon);
            Assert.AreEqual(24.7386, result, epsilon);
        }

        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentException))]
        public void SecantTest3 () {
            RootFinding.Secant(TestFunction3, 0.85, 0.8, -0.0001);
        }

        [TestMethod()]
        public void SecantTest4 () {
            double epsilon = 0.0001;
            double x0 = 0;
            double x1 = 1;
            double result = RootFinding.Secant(TestFunction2, x0, x1, epsilon);
            Assert.AreEqual(0.865474, result, epsilon);
        }
    }
}