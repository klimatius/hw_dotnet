using System;

namespace HW._05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int arraySize;
            while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 0 || arraySize > 100)
            {
                Console.WriteLine("Enter correct size between 1 and 100");
            }

            string[] triangleArr = new string[arraySize];

            for(int i = 0; i < triangleArr.Length; i++)
            {
                for(int k = 0; k < i; k++)
                {
                    triangleArr[i] = triangleArr[i] + (" ");
                }

                for(int j = 0; j < triangleArr.Length - i; j++)
                {
                    triangleArr[i] = triangleArr[i] + ((i+1) % 10);
                    if(j != triangleArr.Length - i - 1)
                        triangleArr[i] = triangleArr[i] + (" ");
                }  
            }

            PrintArray(triangleArr);
        }

        public static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
