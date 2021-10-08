//Student name: Josiah Tsang    
//Student number: 74191248
//Implementing the UniqueWordCount and CountOccurrences methods

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4 {
    public class WordCounter {
        private readonly Dictionary<string, int> map = new Dictionary<string, int>();

        // Use this constructor as is.
        public WordCounter(string url) {
            try {
                // get the content from the web and store in responseBody
                WebContent content = new WebContent(url);
                string responseBody = content.GetWebContent();

                // store all unique words in map (a dictionary)
                foreach (string word in responseBody.Split((string[])null, StringSplitOptions.RemoveEmptyEntries)) {
                    if (map.ContainsKey(word)) {
                        map[word] = map[word] + 1;
                    }
                    else
                        map.Add(word, 1);
                }
            }
            catch (NullReferenceException) {
                Console.WriteLine("Null reference exeption: check the url.");
            }
        }

        /// <summary>
        /// Finds the number of unique words in the file 
        /// that the WordCounter's map is associated with.
        /// </summary>
        /// <returns>the number of unique words</returns>
        public int UniqueWordCount() {
            return 0;
            // ToDo: Implement this method
        }

        /// <summary>
        /// Finds the number of times a word occurs by itself 
        /// (as a complete word) or as part of another word 
        /// in the file that WordCounter is associated with.
        /// If it is a substring of some other word, the count is 
        /// incremented by 1 for each word that wordFragment 
        /// is a substring of, and if word is null or "" then 
        /// 0 is returned.
        /// </summary>
        /// <param name="wordFragment">the word whose 
        /// occurrences to find</param>
        /// <returns>the number of times wordFragment occurs 
        /// in the file that WordCounter is associated with
        /// </returns>
        public int CountOccurrences(string wordFragment) {
            // ToDo: Implement this method
            int count = 0;

        foreach (KeyValuePair<string, int> kvp in map) {

                if (String.IsNullOrEmpty(kvp.Key))
                    count += 0;
                //throw new ArgumentException("argument cannot be empty or null");
                // disassemble kvp.Key to get substrings
                else if (kvp.Key == wordFragment)
                    count += 1;
            }
            
            return count;

        }

        // 
        /// <summary>
        /// a method to make it easier to print details 
        /// of the WordCounter's map.
        /// Use as is.
        /// </summary>
        /// <returns>a string</returns>
        public override string ToString() {
            StringBuilder output = new StringBuilder();
            foreach (KeyValuePair<string, int> item in map) {
                output.Append($"({item.Key}, {item.Value})");
            }
            return output.ToString();
        }
    }
}
