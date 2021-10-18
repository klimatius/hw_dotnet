using System;

namespace HW._05.GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int curHour = DateTime.Now.TimeOfDay.Hours;

            switch (curHour)
            {
                case int n when (n >= 9 && n < 12):
                    Console.WriteLine("Good morning, guys");
                    break;
                case int n when (n >= 12 && n < 15):
                    Console.WriteLine("Good day, guys");
                    break;
                case int n when (n >= 15 && n < 22):
                    Console.WriteLine("Good evening, guys");
                    break;
                default:
                    Console.WriteLine("It's night now");
                    break;
            }
        }
    }
}
