using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(){

            Console.Write("\nWhat is your name?");
            var username = Console.ReadLine();
            Console.WriteLine($"\nHello {username}!");

            int dayOfYear = DateTime.Now.DayOfYear;

            Console.Write("Day of year: ");
            Console.WriteLine(dayOfYear);
        }
    }
}

/*
Console.WriteLine("Enter your studentId:”);
int id = Console.ReadLine();
Console.WriteLine("Your ID is: " + id);
