using System;

namespace HW._05.Quadratic.Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (Math.Pow(b, 2) - 4 * a * c < 0)
            {
                Console.WriteLine("Дискриминант меньше 0. Нет действительных решений.");
            }
            else if (a == 0 && b == 0)
            {
                Console.WriteLine("X - любое действительное число");
            }    
            else if ((a == 0 && c == 0 && b!=0) || (b == 0 && c == 0 && a != 0))
            {
                Console.WriteLine("x = 0");
            }
            else
            {
                double x1, x2;
                x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 / a;
                x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 / a;

                Console.WriteLine("Корни квадратного уравнения: х1 = " + x1 + " x2 = " + x2);
            }
           
        }
    }
}
