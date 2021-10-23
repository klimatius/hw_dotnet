using System;

namespace HW._06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string userString = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userString))
            {
                Console.WriteLine("You enter empty string");
            }
            else if (userString.IndexOf(";") == -1)
            {
                userString = userString.Replace("o", "a").Replace("O", "A").Replace("о", "а").Replace("О", "А");
                Console.WriteLine(userString);
            }
            else
            {
                userString = userString.Replace("o", "a").Replace("O", "A").Replace("о", "а").Replace("О", "А");
                string[] poemArray = userString.Split(new char[] { ';' });

                foreach (string str in poemArray)
                {
                    if(!String.IsNullOrWhiteSpace(str))
                        Console.WriteLine(str);
                }
            }
        }
    }
}
