using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Lab9;

namespace Lab9.Tests {
    [TestClass()]
    public class Lab9Tests {

        [TestMethod()]
        public void TestRecursion1 () {
            Stack<int> testStk = new Stack<int>();
            Stack<int> reversedStk = new Stack<int>();
            Stack<int> expectedStk = new Stack<int>();
            for (int i = 0, j = 9; i < 10; i++, j--) {
                testStk.Push(i);
                expectedStk.Push(j);
            } 
            Recursion.Reverse(testStk, reversedStk);
            CollectionAssert.AreEqual(reversedStk, expectedStk);
        }

        [TestMethod()]
        public void TestRecursion2 () {
            Stack<int> testStk = new Stack<int>();
            Stack<int> expectedStk = testStk;
            for (int i = 0; i < 10; i++) {
                testStk.Push(i);
            }
            Recursion.Reverse(testStk, new Stack<int>());
            CollectionAssert.AreEqual(testStk, expectedStk);
        }

        [TestMethod()]
        public void TestToBinary1 () {
            List<string> ToBinary = new List<string>();
            List<string> Expected = new List<string>(){"1", "10", "11", "100", "101", "110", "111", "1000", "1001"};
            for (int i = 1; i <= 9; i++)
                ToBinary.Add(Recursion.ToBinary(i));
            CollectionAssert.AreEqual(ToBinary, Expected);
        }

        [TestMethod()]
        public void TestToBinary2 () {
            Assert.AreEqual(Recursion.ToBinary(33), "100001");
        }
    }
}
