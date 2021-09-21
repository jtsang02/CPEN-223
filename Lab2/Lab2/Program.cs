// Lab 2 
// Student name: Josiah Tsang
// Student number: 74191248

//Only types in the System and System.Text (and System.Collections.Generic if you want to try List<>) are allowed
using System;
using System.Text;

//Do not change the skeleton. You will only modify the body of the methods.
namespace Lab2
{
    public class Program
    {
        static void Main()
        {
            string str1 = "clint eastwood";
            string str2 = "old east action";
            if (AreAnagrams(str1, str2))
                Console.WriteLine(" they are anagrams");
            else
                Console.WriteLine("not anagrams");
        }

        /// <summary>
        /// checks if str1 and str2 are anagrams
        /// </summary>
        /// <param name="str1">the first string</param>
        /// <param name="str2">the second string</param>
        /// <returns>ture if anagrams, false otherwise</returns>
        public static bool AreAnagrams(string str1, string str2) {
            /*
            char upperChars = 'A';
            char lowerChars = 'a';
            int[] alphabet = new int[53];

            for (int i = 0; i <= 25; i++) {          // map uppercase to locations 0-25 in alphabet
                alphabet[i] = upperChars;
                upperChars++;
            }
            for (int j = 26; j <= 51; j++) {        // map lowercase to locations 26-51 in alphabet
                alphabet[j] = lowerChars;
                lowerChars++;
            }
            alphabet[52] = 32;                      // add space
            */

            // create 2 arrays for each string with ascii chars 
            int[] str1Array = new int[str1.Length];
            int[] str2Array = new int[str2.Length];

            int i = 0;
            foreach(char c in str1) {
                str1Array[i] = c;
                i++;
            }

            int j = 0;
            foreach(char d in str2) {
                str2Array[j] = d;
                j++;
            }

            // sort each string
            Array.Sort(str1Array);
            Array.Sort(str2Array);

            if (str1Array.Length == str2Array.Length) {
                for (int k = 0; k < str1Array.Length; k++) {
                    if (str1Array[k] != str2Array[k])
                        return false;
                }
            }
            else
                return false;

            return true;
        }

        /// <summary>
        /// checks if str is palindrome
        /// </summary>
        /// <param name="str">string to check</param>
        /// <returns>true if pallindrome, false otherwise</returns>
        
        /*
        public static bool IsPalindrome(string str)
        {
            //To Implement
        }

        /// <summary>
        /// checks if str contains a non-trivial palindrome substring
        /// </summary>
        /// <param name="str">string to check</param>
        /// <returns>true if has palindromic substring, false otherwise</returns>
        public static bool HasPalindromicSubstring(string str)
        {
            //To Implement
        }
        */
    }
}