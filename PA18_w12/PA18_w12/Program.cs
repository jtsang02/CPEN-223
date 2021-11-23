using System;

namespace PA18_w12 {
    public class PA {
        static void Main () {
            
            Console.WriteLine(RecursiveSum(5));
            Console.WriteLine(StringToInt("5677"));
        }

        public static int RecursiveSum (int n) {

            if (n == 0)
                return 0;

            int sum;
            sum = n + RecursiveSum(n - 1);
            return sum;

        }
        public static int StringToInt (string str) {

            if (str.Length == 1)
                return str[0] - '0';

            return (int)(StringToInt(str.Substring(1)) + ((str[0] - '0') * Math.Pow(10, str.Length - 1)));
        }
    }
}
