using System;

namespace HW._03.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пару чисел для сложения");
            double a, b;
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Сумма a+b=" + Calculator.Amount(a, b));
            }
            catch
            {
                Console.WriteLine("Одно из чисел введено некорректно");
            }

            Console.WriteLine("Введите пару чисел для вычитания");
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Разность a-b=" + Calculator.Subtraction(a, b));
            }
            catch
            {
                Console.WriteLine("Одно из чисел введено некорректно");
            }

            Console.WriteLine("Введите пару чисел для умножения");
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Произведение a*b=" + Calculator.Multiply(a, b));
            }
            catch
            {
                Console.WriteLine("Одно из чисел введено некорректно");
            }

            Console.WriteLine("Введите пару чисел для деления");
            if(double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b))
            {
                if (b == 0)
                {
                    Console.WriteLine("Результат деления на 0 - бесконечность");
                }
                else
                {
                    Console.WriteLine("Результат деления a/b=" + Calculator.Division(a, b));
                }
            }
            else
            {
                Console.WriteLine("Одно из чисел введено некорректно");
            }

            Console.WriteLine("Введите пару чисел для деления с остатком");
            if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b))
            {
                if (b == 0)
                {
                    Console.WriteLine("Результат деления на 0 - бесконечность");
                }
                else
                {
                    Console.WriteLine("Результат деления a%b=" + Calculator.DivisionRest(a, b));
                }
            }
            else
            {
                Console.WriteLine("Одно из чисел введено некорректно");
            }

            Console.WriteLine("Введите радиус круга");
            if (double.TryParse(Console.ReadLine(), out a))
            {
                if (a <= 0)
                {
                    Console.WriteLine("Радиус круга не может быть равен 0 или отрицательным");
                }
                else
                {
                    Console.WriteLine("Площадь круга: " + Calculator.CircleSquare(a));
                }
            }
            else
            {
                Console.WriteLine("Радиус введен некорректно");
            }
        }
    }

    class Calculator
    {
        public static double Amount(double x, double y)
        {
            return x + y;
        }

        public static double Subtraction(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Division(double x, double y)
        {
            return x / y;
        }

        public static double DivisionRest(double x, double y)
        {
            return x % y;
        }
        public static double CircleSquare(double x)
        {
            return Math.PI * x * x;
        }
    }
}
