using System;
using System.Collections.Generic;

public class Program {
    static void Main() {

        Queue<string> str = new Queue<string>();        // create a queue of strings to represent a print jobs queue

        str.Enqueue("Hello");                           // enqueue "Hello", "How are you?" and "Good to see you!"
        str.Enqueue("How are you?");
        str.Enqueue("Good to see you!");

        int length = str.Count;
        while (length != 0) {                           // use a loop to dequeue and print all print jobs (Do NOT use foreach)
            Console.WriteLine(str.Dequeue());
            length--;
        }
    }
}
