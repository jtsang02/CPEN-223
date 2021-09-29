// Lab 3 
// Student name: Josiah Tsang
// Student number: 74191248

using System;
using System.Collections.Generic;
using System.Numerics;

namespace Lab3 {
    public class Program {

        static void Main() {

            List<int> arrayTestPPP = new List<int>() { 0, 2, 9, 253, 11, 9, 21, 21, 253, 348, 211, 204, 47, 53 };
            GetAllPPPrimes(arrayTestPPP).ForEach(Console.WriteLine);
        }

        public static List<int> GetAllPPPrimes(List<int> intList) {

            List<int> newList = new List<int>();
            intList.Sort();

            int temp = 0;                                               // temp variable that is not PPP
            for (int i = 0; i < intList.Count; i++)                     
                if (IsPPPrime(intList[i]) && intList[i] != temp) {      // check for back to back repeats in sorted list
                    newList.Add(intList[i]);                            
                    temp = intList[i];                                  // set temp variable to added PPP    
                }

            return newList;
        }
        public static bool IsPPPrime(int num) {

            if (num == 2 || num == 3 || num == 5)   return true;        // specific conditions

            int count = 0;
            for (int a = 2; a < num; a++) { 
                BigInteger A = BigInteger.Pow(a, num) % num;
                if (A == a && a % 3 == 0)
                    count++;
                if (count > 1)  return true;
            }
            
            return false;
        }
    }
}