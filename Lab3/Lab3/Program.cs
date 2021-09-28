// Lab 3 
// Student name: Josiah Tsang
// Student number: 74191248

using System;
using System.Collections.Generic;
using System.Numerics;

namespace Lab3 {
    public class Program {

        static void Main() {

            List<int> arrayTestPPP = new List<int>() { 2, 9, 11, 11, 21, 21, 253, 348, 211, 204, 47, 53 };

            /*(foreach (int item in arrayTestPPP) { 
                if (IsPPPrime(item))
                    Console.WriteLine(item + " is a probable prime");
                else
                    Console.WriteLine(item + " is not a probable prime");
            }*/
            GetAllPPPrimes(arrayTestPPP).ForEach(Console.WriteLine);
        }

        public static List<int> GetAllPPPrimes(List<int> intList) {

            // original idea with one pass
            // create new list that will hold PPPs
            // iterate thru intList to find PPPs, add them to new list in ascending order and check for duplicates

            int[] tempArray = new int[intList.Count];
            List<int> newList = new List<int>();

            int temp = 0;
            for (int i = 0; i < intList.Count; i++) {
                if (IsPPPrime(intList[i]) && temp != intList[i]) {
                    tempArray[i] = intList[i];
                    temp = intList[i];
                    //Console.WriteLine(temp);
                }
            }
            //Console.WriteLine("break");

            Array.Sort(tempArray);

            for (int i = 0; i < tempArray.Length; i++)
                if (tempArray[i] != 0)
                    newList.Add(tempArray[i]);

            return newList;
        }
        public static bool IsPPPrime(int num) {

            if (num == 2 || num == 3 || num == 5)
                return true;

            int count = 0;
            for (int a = 2; a < num; a++) { 
                BigInteger A = BigInteger.Pow(a, num) % num;
                if (A == a && a % 3 == 0) {
                    count++;
                    //Console.WriteLine("a or b is " + a);
                }
                if (count > 1)
                    return true;
            }

            return false;
        }
    }
}