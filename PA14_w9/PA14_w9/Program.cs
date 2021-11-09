using System;

public class Program {
    static void Main () {

        // test Swap function
        int x = 1;
        int y = 2;
        Swap(ref x, ref y);

        Console.WriteLine($"x is now {x} and y is now {y}");

        // test GetInt function
        if (GetInt(out int num))
            Console.WriteLine($"The entered number is {num}");
        else
            Console.WriteLine("not a valid integer.");

    }

    /// <summary>
    /// Swaps the values of the two method parameters x and y.
    /// </summary>
    /// <param name="x">first int parameter</param>
    /// <param name="y">second int parameter</param>
    public static void Swap (ref int x, ref int y) {

        int temp = x;
        x = y;
        y = temp;

    }

    /// <summary>
    /// Gets an int from the console, and the value is passed
    /// to the calling method using an out parameter.
    /// </summary>
    /// <param name="userInput">an out parameter to output the int value</param>
    /// <returns>true if an int is successfully received from the console, false otherwise</returns>
    public static bool GetInt (out int userInput) {

        Console.Write("enter an integer: ");
        string s = Console.ReadLine().Trim();
        bool isInt = int.TryParse(s, out userInput);
        return isInt;

    }
}