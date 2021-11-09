using System;
using System.Collections.Generic;

public class Program {

    // Return the length of longest balanced parentheses string.
    static int balancedLen (string S) {

        int longestCount = 0;
        Stack<char> balancedStack = new Stack<char>();

        for (var i = 0; i < S.Length; i++) {

            if (S[i] == '(')
                balancedStack.Push(S[i]);
            else if (S[i] == ')')
                balancedStack.Pop();

            if (balancedStack.Count == 0)
                longestCount = i + 1;
        }
        return longestCount;
    }

    public static void Main () {

        string str = "(((()())()))((";
        Console.WriteLine(balancedLen(str));

        string S = "((()))((()()()";
        Console.WriteLine(balancedLen(S));
    }
}