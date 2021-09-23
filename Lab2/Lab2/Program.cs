// Lab 2 
// Student name: Josiah Tsang
// Student number: 74191248

//Only types in the System and System.Text (and System.Collections.Generic if you want to try List<>) are allowed
using System;
using System.Text;

namespace Lab2 {
    public class Program {
        static void Main() {

            // anagram test
            string str1 = "clinteastwood";
            string str2 = "oldwestaction";

            if (AreAnagrams(str1, str2))
                Console.WriteLine("they are anagrams");
            else
                Console.WriteLine("not anagrams");

            // palindrome test
            if (IsPalindrome("racecar"))
                Console.WriteLine("string is a palindrome");
            else
                Console.WriteLine("string is not a palindrome");

            // palindromicsub test
            if (HasPalindromicSubstring("cpen"))
                Console.WriteLine("string has non-trivial palindromic substring");
            else
                Console.WriteLine("string does not have non-trivial palindromic substring");

        }

        public static bool AreAnagrams(string str1, string str2) {

            int[] str1Array = new int[str1.Length];                 // create 2 empty arrays for each string with ascii chars 
            int[] str2Array = new int[str2.Length];

            if (str1Array.Length == str2Array.Length) {             // if array lengths are same continue

                int i = 0;
                foreach (char c in str1) {                          // fill str1 array with ascii values
                    str1Array[i] = c;
                    i++;
                }

                int j = 0;
                foreach (char d in str2) {                          // fill str2 array with ascii values
                    str2Array[j] = d;
                    j++;
                }

                Array.Sort(str1Array);                              // sort each string
                Array.Sort(str2Array);

                for (int k = 0; k < str1Array.Length; k++) {
                    if (str1Array[k] != str2Array[k])
                        return false;
                }
            }
            else
                return false;

            return true;
        }

        public static bool IsPalindrome(string str) {

            char[] strArray = str.ToCharArray();                    // convert string to char array
            Array.Reverse(strArray);                                // reverse char array
            string reverse = new string(strArray);                  // make new string with reversed char array

            return String.Equals(str, reverse);                     // compare strings
        }

        public static bool HasPalindromicSubstring(string str) {

            bool[,] grid = new bool[str.Length, str.Length];        // create n x n boolean array

            for (int i = 0; i < str.Length; i++)                    // fill diagonal with true because all single chars are palindromes
                grid[i, i] = true;

            for (int i = 1; i < str.Length; i++)                    // iterate through upper triangle of symmetrical array 
                for (int j = 0; j < i; j++)
                    if (j == i - 1 && str[i] == str[j])             // check for lengths of 2
                        return true;                    
                    else                                            // check for lengths greater than 2
                        if (grid[j + 1, i - 1] && str[i] == str[j])
                            return true;
                        
            return false;
        }     
    }
}