using System;
using System.Text;

namespace Activity
{
    class Program
    {
        static void Main()
        {
            // driver
            string message = "123 $ Word";
            Console.WriteLine(ToggleCase(message));
        }
        static string ToggleCase(string str) { 
            
            StringBuilder tempString = new StringBuilder();
            
            for (int index = 0; index < str.Length; index++)
            {
                if (Char.IsUpper(str[index]))
                {
                    tempString.Append(char.ToLower(str[index]));
                }
                else if (Char.IsLower(str[index]))
                {
                    tempString.Append(char.ToUpper(str[index]));
                }
                else
                    tempString.Append(str[index]);
            }

            return tempString.ToString();
                //Console.WriteLine(str[i]);
            
            //to implement

            // create an empty StringBuilder
            // loop to check every elements of str one by one
            //if uppercase, convert to lowercase and append
            //else if lowercase, convert to uppercase and append
            //else keep as is and append
            //convert to string and return

        }
    }
}