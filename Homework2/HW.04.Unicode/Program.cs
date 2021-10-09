using System;
using System.IO;

namespace HW._04.Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello guys from the most popular programming course - C#!";
            string text = default;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    Console.WriteLine();
                    text += "\r\n";
                }
                else
                {
                    Console.WriteLine(str[i] + " = " + Convert.ToString(str[i], 10) + " = " + Convert.ToString(str[i], 2));
                    text += str[i] + " = " + Convert.ToString(str[i], 10) + " = " + Convert.ToString(str[i], 2) + "\r\n"; ;
                }
            }
            File.WriteAllText(@"C:\Users\klima\Desktop\HW4.txt", text);
        }
    }
}
