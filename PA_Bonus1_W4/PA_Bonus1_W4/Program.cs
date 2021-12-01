using System;
using System.Collections.Generic;

// Code:
// Implements SimpleQueue to isner music into a list
// Implements SimpleStack to insert a music into a list

// =======================================================================================
// Tasks:
// Indicate the code debugging procedure (steps you take)
// Which access modifiers can become more secure ( Which of the public methods/fields can be private), and Why/Why not?


namespace Week4_Playlist {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine("SimpleQueue results:");
            SimpleQueue q = new SimpleQueue();
            for (int i = 0; i < 10; i++)
                q.Enqueue(FriendsSaid.listen());
            for (int i = 0; i < 10; i++)
                Console.WriteLine(q.Dequeue());

            Console.WriteLine("SimpleStack results:");
            SimpleStack s = new SimpleStack();
            for (int i = 0; i < 10; i++)
                s.Push(FriendsSaid.listen());
            for (int i = 0; i < 10; i++)
                Console.WriteLine(s.Pop());

        }
    }

    // Simulating Queue with List<>
    class SimpleQueue {
        private List<string> list;
        public SimpleQueue () {
            list = new List<string>();
        }

        public void Enqueue (string item) {
            list.Add(item);
        }

        public string Dequeue () {
            if (list.Count > 0) {
                string result = list[0];
                list.RemoveAt(0);
                return result;
            }
            else
                return "";
        }

        public string Peek () {
            if (list.Count > 0) {
                string result = list[0];
                return result;
            }
            else
                return "";
        }

    }

    // Simulating Stack with List<>
    class SimpleStack {

        private List<string> list;
        public SimpleStack () {
            list = new List<string>();
        }

        public void Push (string item) {
            list.Add(item);
        }

        public string Pop () {
            if (list.Count > 0) {
                string result = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return result;
            }
            else
                return "";
        }

        public string Peek () {
            if (list.Count > 0) {
                string result = list[list.Count - 1];
                return result;
            }
            else
                return "";
        }
    }

    class FriendsSaid {

        public static string[] music_list = {
            "Stay",
            "Bad Habits",
            "Fair Trade",
            "Industry Baby",
            "Knife Talk",
            "Shivers  Highest Debut",
            "Heat Waves",
            "Girls Want Girls",
            "Good 4 U",
            "Levitating"
        };
        public static int added = -1;
        public static string listen () {
            if (added < music_list.Length - 1) {
                added++;
                return music_list[added];
            }
            else {
                return music_list[added];
            }
        }
    }


}