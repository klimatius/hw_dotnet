using System;
using System.Text;

namespace HW._03.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
        }

        static void Task1()
        {
            double num1, num2;
            string tempStr;

            Console.WriteLine("Введите число 1");
            tempStr = Console.ReadLine();

            while (!double.TryParse(tempStr, out num1))
            {
                if (!double.TryParse(tempStr, out num1))
                {
                    Console.WriteLine("Введённый символ не число");
                    Console.WriteLine("Введите число 1");
                    tempStr = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите число 2");
            tempStr = Console.ReadLine();

            while (!double.TryParse(tempStr, out num2))
            {
                if (!double.TryParse(tempStr, out num2))
                {
                    Console.WriteLine("Введённый символ не число");
                    Console.WriteLine("Введите число 2");
                    tempStr = Console.ReadLine();
                }
            }

            Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
        }

        static void Task2()
        {
            double num1, num2, sum;
            string tempStr;

            Console.WriteLine("Введите число 1");
            tempStr = Console.ReadLine();

            while (!double.TryParse(tempStr, out num1))
            {
                if (!double.TryParse(tempStr, out num1))
                {
                    Console.WriteLine("Введённый символ не число");
                    Console.WriteLine("Введите число 1");
                    tempStr = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите число 2");
            tempStr = Console.ReadLine();

            while (!double.TryParse(tempStr, out num2))
            {
                if (!double.TryParse(tempStr, out num2))
                {
                    Console.WriteLine("Введённый символ не число");
                    Console.WriteLine("Введите число 2");
                    tempStr = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите итог");
            tempStr = Console.ReadLine();

            while (!double.TryParse(tempStr, out sum))
            {
                if (!double.TryParse(tempStr, out sum))
                {
                    Console.WriteLine("Введённые символы не число");
                    Console.WriteLine("Введите корректный итог");
                    tempStr = Console.ReadLine();
                }
            }

            if(num1 + num2 == sum)
            {
                Console.WriteLine("Правильно");
            }
            else
            {
                Console.WriteLine("Неправильно");
            }
        }

        static void Task3()
        {
            double num1, num2, sum;
            string tempStr;

            Console.WriteLine("Введите число 1");
            tempStr = Console.ReadLine();

            while (!double.TryParse(tempStr, out num1))
            {
                if (!double.TryParse(tempStr, out num1))
                {
                    Console.WriteLine("Введённый символ не число");
                    Console.WriteLine("Введите число 1");
                    tempStr = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите число 2");
            tempStr = Console.ReadLine();

            while (!double.TryParse(tempStr, out num2))
            {
                if (!double.TryParse(tempStr, out num2))
                {
                    Console.WriteLine("Введённый символ не число");
                    Console.WriteLine("Введите число 2");
                    tempStr = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите итог");
            tempStr = Console.ReadLine();

            while (!double.TryParse(tempStr, out sum))
            {
                if (!double.TryParse(tempStr, out sum))
                {
                    Console.WriteLine("Введённые символы не число");
                    Console.WriteLine("Введите корректный итог");
                    tempStr = Console.ReadLine();
                }
            }

            if (num1 + num2 == sum)
            {
                Console.WriteLine("Правильно");
            }
            else
            {
                Console.WriteLine("Неправильно");
                if(num1 + num2 > sum)
                {
                    Console.WriteLine("Должно быть больше");
                }
                else
                {
                    Console.WriteLine("Должно быть меньше");
                }
            }
        }

        static void Task4()
        {
            double num1, num2, sum, controlSum;
            string tempStr;
            char oper;

            Console.WriteLine("Введите число 1");
            tempStr = Console.ReadLine();

            while (!double.TryParse(tempStr, out num1))
            {
                if (!double.TryParse(tempStr, out num1))
                {
                    Console.WriteLine("Введённый символ не число");
                    Console.WriteLine("Введите число 1");
                    tempStr = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите число 2");
            tempStr = Console.ReadLine();

            while (!double.TryParse(tempStr, out num2))
            {
                if (!double.TryParse(tempStr, out num2))
                {
                    Console.WriteLine("Введённый символ не число");
                    Console.WriteLine("Введите число 2");
                    tempStr = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите оператор");
            tempStr = Console.ReadLine();

            while (!char.TryParse(tempStr, out oper) || !(oper == '+' || oper == '-'))
            {
                if (oper != '+' || oper != '-')
                {
                    Console.WriteLine("Введённый символ не + или -");
                    Console.WriteLine("Введите корректный оператор");
                    tempStr = Console.ReadLine();
                }
            }

            Console.WriteLine("Введите итог");
            tempStr = Console.ReadLine();

            while (!double.TryParse(tempStr, out sum))
            {
                if (!double.TryParse(tempStr, out sum))
                {
                    Console.WriteLine("Введённые символы не число");
                    Console.WriteLine("Введите корректный итог");
                    tempStr = Console.ReadLine();
                }
            }

            controlSum = (oper == '+') ? num1 + num2 : num1 - num2; 


            if (controlSum == sum)
            {
                Console.WriteLine("Правильно");
            }
            else
            {
                if (controlSum > sum)
                {
                    Console.WriteLine("Должно быть больше");
                }
                else
                {
                    Console.WriteLine("Должно быть меньше");
                }
            }
        }

        static void Task5()
        {
            Console.WriteLine("Английский алфавит в обратном порядке");
            for(int i = 90; i >= 65; i--)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
        }

        static void Task6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите символ W A S D для перемещения");
            char sym;
            string result = default, tmp;
            bool flag = true;
            tmp = Console.ReadLine().ToLower();
            while (char.TryParse(tmp, out sym) && flag)
            {
                switch (sym)
                {
                    case 'w':
                        result += Convert.ToChar(8593);
                        tmp = Console.ReadLine().ToLower();
                        break;
                    case 'a':
                        result += Convert.ToChar(8592);
                        tmp = Console.ReadLine().ToLower();
                        break;
                    case 's':
                        result += Convert.ToChar(8595);
                        tmp = Console.ReadLine().ToLower();
                        break;
                    case 'd':
                        result += Convert.ToChar(8594);
                        tmp = Console.ReadLine().ToLower();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
            Console.WriteLine("Перемещение завершено. Путь фигуры: " + result);
        }
    }
}
