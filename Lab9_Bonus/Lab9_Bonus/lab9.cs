//Student name:     Josiah Tsang
//Student number:   74191248
// https://canvas.ubc.ca/courses/77990/pages/lab9-bonus-dec-2?module_item_id=3860687

using System;
using System.Collections.Generic;

namespace Lab9 {
    public class lab9 {

        static void Main () {
            //You could mainly use unit tests for testing.
            for (int i = 1; i < 21; i++)
            Console.WriteLine(Recursion.ToBinary(i));
        }

    }
    public class Recursion {

        /// <summary>
        /// Provides the reverse of stack through the second method parameter which is modified.
        /// </summary>
        /// <param name="stack">The stack whose reverse we want to obtain. It must not be modified when method returns.</param>
        /// <param name="reversed">A stack containing the reverse of stack. Originally, reversed is an empty stack.</param>
        public static void Reverse (Stack<int> stack, Stack<int> reversed) {

            //base case
            if (stack == null || stack.Count <= 0)
                return;

            //recursive step
            int temp = stack.Pop();
            reversed.Push(temp);
            Reverse(stack, reversed);
            stack.Push(temp);
        }
       
        /// <summary>
        /// Determines if sub is a subset of set.
        /// </summary>
        /// <param name="sub">A list representing a set of integers. Duplicate elements are allowed. sub may be modified.</param>
        /// <param name="set">A list representing a set of integers. Duplicate elements are allowed.</param>
        /// <returns>True if sub is a subset of set, false otherwise.</returns>
        public static bool IsASubset (List<int> sub, List<int> set) {

            //base case
            if (sub.Count == 0)
                return true;

            //recursive step
            if (set.Contains(sub[sub.Count - 1])) {
                sub.Remove(sub[sub.Count - 1]);
                if (IsASubset(sub, set))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Finds and returns the binary equivalent of the positive integer num.
        /// </summary>
        /// <param name="num">The integer whose binary equivalent to find. num is greater than 0.</param>
        /// <returns>A string containing the binary equivalent of num.</returns>
        public static string ToBinary (int num) {

            //base case
            if (num == 0)
                return string.Empty;

            //recursive step
            return ToBinary(num / 2) + (num % 2).ToString();
        }
    }
}