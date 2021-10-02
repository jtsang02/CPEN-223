using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EquationSolver;

namespace PA2_w2Tests {
    [TestClass]
    public class QuadraticEquationsTests {
        [TestMethod]
        public void PrintsRootsCorrectly() {

            // Arrange
            double a = 1;
            double b = 2;
            double c = 1;
            QuadraticEquation testEqn = new QuadraticEquation(a, b, c);

            // Act
            bool result = testEqn.RealRoots();

            // Assert
            Assert.IsTrue(result, "there are no real roots");

        }

    }
}
