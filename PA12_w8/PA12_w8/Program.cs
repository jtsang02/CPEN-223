using System;

public class NewtonRaphsonExample {
    static void Main () {

        Console.Write(NewtonRaphson1());
    
    }
    /// <summary>
    /// Using Newton-Raphson, this method calculates the root x.
    /// The method stop its search when the abosulte value of 
    /// SampleFunc1(x) is less than epsilon (consider 0.00001).
    /// The method stops the search also if the above is not achieved
    /// within 500 iterations.
    /// </summary>
    /// <returns>The root of the function specified in the SampleFunc1 method.</returns>
    static double NewtonRaphson1 () {

        try {
            double x = 0.5;                         // initial guess
            int maxAttempts = 500;
            for (int i = 0; i < maxAttempts; i++) {
                double x_n = x - (SampleFunc1(x) / SampleFunc1Prime(x));
                if (Math.Abs(x_n - x) < 0.00001)
                    return x_n;
                x = x_n;
            }
        }
        catch (DivideByZeroException) {
            Console.WriteLine("f'(x) cannot be 0 in denominator");
        }
        return 0;
    }

    //This is the function whose root we want to find
    static double SampleFunc1 (double x) {
        return Math.Cos(x) - x * x * x;
    }

    //this is the first derivative of the function whose root we want to find
    static double SampleFunc1Prime (double x) {
        return -Math.Sin(x) - 3 * x * x;
    }
}
