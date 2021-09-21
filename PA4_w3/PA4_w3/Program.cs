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
   
        }
    }
}