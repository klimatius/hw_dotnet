using System;
using System.Diagnostics;

namespace HW._05.Task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }

        public static void Task1()
        {
            Console.WriteLine("Enter array size");
            int arraySize;
            while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 0)
            {
                Console.WriteLine("Enter correct size");
            }

            int[] randArr = new int[arraySize];
            int[] userArr = new int[arraySize];
            int[] finalArr = new int[arraySize];
            Random rnd = new Random();

            for (int i = 0; i < randArr.Length; i++)
            {
                randArr[i] = rnd.Next(1, 10);
                Console.WriteLine("Enter array element " + i);
                while (!int.TryParse(Console.ReadLine(), out userArr[i]))
                {
                    Console.WriteLine("Enter correct element " + i);
                }
                finalArr[i] = randArr[i] + userArr[i];
            }

            Console.WriteLine("Random Array:");
            PrintArray(randArr);
            Console.WriteLine("User Array:");
            PrintArray(userArr);
            Console.WriteLine("Final Array:");
            PrintArray(finalArr);
        }

        public static void Task2()
        {
            Console.WriteLine("Enter array size");
            int arraySize;
            while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 1)
            {
                Console.WriteLine("Enter correct size");
            }

            int[] userArr = new int[arraySize];
            int value, position;

            for (int i = 0; i < userArr.Length - 1; i++)
            {
                Console.WriteLine("Enter array element " + i);
                while (!int.TryParse(Console.ReadLine(), out userArr[i]))
                {
                    Console.WriteLine("Enter correct element " + i);
                }
            }

            PrintArray(userArr);

            Console.WriteLine("Enter value");
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Enter correct value");
            }

            Console.WriteLine("Enter position");
            while (!int.TryParse(Console.ReadLine(), out position) || position < 0 || position > userArr.Length - 1)
            {
                Console.WriteLine("Enter correct position");
            }

            Array.Copy(userArr, position, userArr, position + 1, userArr.Length - position - 1);
            userArr[position] = value;

            PrintArray(userArr);
        }

        public static void Task3()
        {
            Console.WriteLine("Enter array size");
            int arraySize;
            while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 0)
            {
                Console.WriteLine("Enter correct size");
            }

            int[] randArr = new int[arraySize];
            Random rnd = new Random();

            for (int i = 0; i < randArr.Length; i++)
            {
                randArr[i] = rnd.Next(1, 10);
            }

            Console.WriteLine("Array:");
            PrintArray(randArr);

            int tmpNum;
            //var timer = new Stopwatch();

            //timer.Start();
            for (int i = 0; i < randArr.Length / 2; i++)
            {
                tmpNum = randArr[i];
                randArr[i] = randArr[randArr.Length - i - 1];
                randArr[randArr.Length - i - 1] = tmpNum;
            }
            //timer.Stop();
            //Console.WriteLine("Time for my reverse: " + timer.ElapsedMilliseconds);

            //timer.Reset();
            //timer.Start();
            //Array.Reverse(randArr);
            //timer.Stop();
            //Console.WriteLine("Time for standart reverse: " + timer.ElapsedMilliseconds);

            Console.WriteLine("Reversed array:");
            PrintArray(randArr);
            
        }

         public static void PrintArray(int [] arr)
         {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
