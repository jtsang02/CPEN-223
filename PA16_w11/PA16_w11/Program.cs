using System;

public class MyClass {
    static void Main () {   //To implement: used for testing

        //include two test cases for each of the methods
        long[] interateArray = new long[20];
        long[] recursionArray = new long[20];

        for (int n = 0; n < 20; n++) {
            interateArray[n] = Factorial_iteration(n);
            recursionArray[n] = Factorial_recursion(n);
        }

        Console.WriteLine("The factorials from 0 to 20 by iteration are:");
        foreach (long val in interateArray)
            Console.Write($"{val} ");
        
        Console.WriteLine();

        Console.WriteLine("The factorials from 0 to 20 by recursion are:");
        foreach (long val in recursionArray)
            Console.Write($"{val} ");
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