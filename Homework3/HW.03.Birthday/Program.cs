using System;

namespace HW._03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear, birthMonth, curYear, curMonth;
            string tempStr;


            Console.WriteLine("Введите год рождения");
            tempStr = Console.ReadLine();

            while (!int.TryParse(tempStr, out birthYear))
            {
                if (!int.TryParse(tempStr, out birthYear))
                {
                    Console.WriteLine("Введите корректное число");
                    tempStr = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите месяц рождения");
            tempStr = Console.ReadLine();

            while (!int.TryParse(tempStr, out birthMonth) || (birthMonth < 1 || birthMonth > 12))
            {
                if (!int.TryParse(tempStr, out birthMonth) || (birthMonth < 1 || birthMonth > 12))
                {
                    Console.WriteLine("Введите корректное число");
                    tempStr = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите текущий год");
            tempStr = Console.ReadLine();

            while (!int.TryParse(tempStr, out curYear))
            {
                if (!int.TryParse(tempStr, out curYear))
                {
                    Console.WriteLine("Введите корректное число");
                    tempStr = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите текущий месяц");
            tempStr = Console.ReadLine();

            while (!int.TryParse(tempStr, out curMonth) || (curMonth < 1 || curMonth > 12))
            {
                if (!int.TryParse(tempStr, out curMonth) || (curMonth < 1 || curMonth > 12))
                {
                    Console.WriteLine("Введите корректное число");
                    tempStr = Console.ReadLine();
                }
            }

            if (curMonth >= birthMonth)
            {
                Console.WriteLine("Полных лет: " + (curYear - birthYear));
            }
            else
            {
                Console.WriteLine("Полных лет: " + (curYear - birthYear - 1));
            }
        }
    }
}
