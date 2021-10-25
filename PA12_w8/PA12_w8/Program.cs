using System;

public class NewtonRaphsonExample {
    static void Main () {
        //Write code here to test the method
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
        // To implement

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
