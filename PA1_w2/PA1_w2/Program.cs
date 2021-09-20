using System;

namespace StarFormation
{
    class Program
    {
        static void Main()
        {
            PrintStars(1);

            Console.WriteLine();

            PrintStars(3);

            Console.WriteLine();

            PrintStars(5);
        }
        static void PrintStars(int size)
        {
            int counter = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write('*');
                
                Console.WriteLine();
            }        

        }
    }
}