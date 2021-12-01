using System;
namespace PA13 {
    public class Program {
        static void Main () {

            Console.WriteLine($"The root is { RootFinding.NewtonRaphson(Func, FPrime, 0.5)}");

        }
        static double Func (double x) {

            return Math.Cos(x) - x * x * x;

        }
        static double FPrime (double x) {

            return -Math.Sin(x) - 3 * x * x;

        }
    }
    public class RootFinding {

        public delegate double Function (double x);

        public static double NewtonRaphson (Function f, Function fPrime, double guess) {
            
            try {
                const double epsilon = 0.0001;
                int maxAttempts = 300;
                for (int i = 0; i < maxAttempts; i++) {
                    double x_n = guess - (f(guess) / fPrime(guess));
                    if (Math.Abs(x_n - guess) < epsilon)
                        return x_n;
                    guess = x_n;
                }
            }
            catch (DivideByZeroException) {
                Console.WriteLine("f'(x) cannot be 0 in denominator");
            }
            return double.NaN;
        }
    }

}