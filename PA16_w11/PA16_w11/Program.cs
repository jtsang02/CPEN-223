using System;

public class MyClass {
    static void Main () {   //To implement: used for testing

        //include two test cases for each of the methods
        for (int n = 0; n < 20; n++) {
            Console.Write($"Recursive: {n}!={Factorial_recursion(n)}   ");
            Console.WriteLine($"Iterative: {n}!= {Factorial_iteration(n)}");
        }
    }

    public static long Factorial_iteration (int num) {  // implement factorial using iteration (non-recursively)

        if (num == 0)   return 1;
        long fact = num;

        num--;
        while (num > 0) {
            fact *= num;
            num--;
        }

        return fact;

    }
    public static long Factorial_recursion (int num) {  // implement factorial recursively

        if (num == 0)   return 1;

        long fact = num * Factorial_recursion(num - 1);

        return fact;
    }
}