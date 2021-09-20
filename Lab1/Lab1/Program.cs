// Name: Josiah Tsang
// Student number: 74191248

using System;
using System.Text;

namespace TargetSumCheck  { //do not change this line

    public class Program { //do not change this line
    
        public static void Main() {

            Console.WriteLine("Lab 1 exercise");

            int[] testArray = new int[] { 2, 3, 42, 12, 7 };
            //int[] testArray = new int[] {  0, 1 };

            int target = 0;

            bool check1 = CheckSum1(testArray, target);

            if (check1) {
                Console.WriteLine("Variant 1: One can select three elements from " + ToString(testArray) + $" that sum to {target}.");
            }
            else {
                Console.WriteLine("Variant 1: One cannot select three elements from " + ToString(testArray) + $" that sum to {target}.");
            }

            bool check2 = CheckSum2(testArray, target);

            if (check2) {
                Console.WriteLine("Variant 2: One can select three elements from " + ToString(testArray) + $" that sum to {target}.");
            }
            else {
                Console.WriteLine("Variant 2: One cannot select three elements from " + ToString(testArray) + $" that sum to {target}.");
            }
        }
        
        public static bool CheckSum1(int[] array, int target) {         /// Duplicates are allowed.

            int[] data = new int[3];

            for (int i = 0; i < array.Length; i++) { // get first value of new array
                data[0] = array[i];
                if (data[0] * 3 == target)           // check duplicates
                    return true;
                for (int j = i + 1; j < array.Length; j++) { // get 2nd value of new array
                    data[1] = array[j];
                    if (data[0] * 2 + data[1] == target || data[0] + data[1] * 2 == target)     // check for more duplicates
                        return true;
                    for (int k = j + 1; k < array.Length; k++) { // get 3rd value of new array
                        data[2] = array[k];  
                        if (data[0] + data[1] + data[2] == target)
                            return true;                
                    }
                }   
            }

            return false;
        }

        public static bool CheckSum2(int[] array, int target) {     /// Duplicates are not allowed.

            int[] data = new int[3];

            for (int i = 0; i < array.Length; i++) { // get first value of new array
                data[0] = array[i];
                for (int j = i + 1; j < array.Length; j++) { // get 2nd value of new array
                    data[1] = array[j];
                    for (int k = j + 1; k < array.Length; k++) { // get 3rd value of new array
                        data[2] = array[k];
                        if (data[0] + data[1] + data[2] == target)
                            return true;
                    }
                }
            }

            return false;
        }

        static string ToString(int[] array) {
            if (array == null) {
                return null;
            }

            StringBuilder output = new StringBuilder();
            output.Append("{ ");
            foreach (int x in array) {
                output.Append(x);
                output.Append(" ");
            }

            output.Append("}");
            return output.ToString();
        }
    }
}