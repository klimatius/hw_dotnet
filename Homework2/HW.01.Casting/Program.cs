using System;

namespace HW._01.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.2.a
            Console.WriteLine("Задание 1.2.a");
            double numDouble = 1;
            int numInt = (int)numDouble;
            float numFloat = (float)numDouble;
            short numShort = (short)numDouble;
            ushort numUshort = (ushort)numDouble;
            uint numUint = (uint)numDouble;
            Console.WriteLine("Тип переменной numInt: " + numInt.GetType());
            Console.WriteLine("Тип переменной numFloat: " + numFloat.GetType());
            Console.WriteLine("Тип переменной numShort: " + numShort.GetType());
            Console.WriteLine("Тип переменной numUshort: " + numUshort.GetType());
            Console.WriteLine("Тип переменной numUint: " + numUint.GetType());

            // 1.2.b 
            Console.WriteLine("Задание 1.2.b");
            numDouble = numInt;
            numInt = numShort;
            numUint = numUshort;
            numDouble = numUshort;
            numInt = numUshort;
            Console.WriteLine("Тип переменной numInt: " + numInt.GetType());
            Console.WriteLine("Тип переменной numFloat: " + numFloat.GetType());
            Console.WriteLine("Тип переменной numShort: " + numShort.GetType());
            Console.WriteLine("Тип переменной numUshort: " + numUshort.GetType());
            Console.WriteLine("Тип переменной numUint: " + numUint.GetType());

            // 1.2.c
            Console.WriteLine("Задание 1.2.c");
            object objFloat = numFloat;
            object objDouble = numDouble;
            object objInt = numInt;
            object objUshort = numUshort;
            object objUint = numUint;
            Console.WriteLine("Тип переменной objFloat: " + objFloat.GetType());
            Console.WriteLine("Тип переменной objDouble: " + objDouble.GetType());
            Console.WriteLine("Тип переменной objInt: " + objInt.GetType());
            Console.WriteLine("Тип переменной objUshort: " + objUshort.GetType());
            Console.WriteLine("Тип переменной objUint: " + objUint.GetType());


            // 1.2.d
            Console.WriteLine("Задание 1.2.d");
            numInt = (int)objInt;
            Console.WriteLine("Тип переменной numInt: " + numInt.GetType());
            numFloat = (float)objFloat;
            Console.WriteLine("Тип переменной numFloat: " + numFloat.GetType());
            numUshort = (ushort)objUshort;
            Console.WriteLine("Тип переменной numUshort: " + numUshort.GetType());
            numUint = (uint)objUint;
            Console.WriteLine("Тип переменной numUint: " + numUint.GetType());
            numDouble = (double)objDouble;
            Console.WriteLine("Тип переменной numDouble: " + numDouble.GetType());


        }
    }
}
