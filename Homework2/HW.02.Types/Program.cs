using System;

namespace HW._02.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.a
            Console.WriteLine("Задание 2.a");
            bool boolValue = default;
            Boolean boolValueCLR = default;
            Console.WriteLine("Тип переменной boolValue: " + boolValue.GetType());
            Console.WriteLine("Тип переменной boolValueCLR: " + boolValueCLR.GetType());

            sbyte numSbyte = default;
            SByte numSbyteCLR = default;
            Console.WriteLine("Тип переменной numSbyte: " + numSbyte.GetType());
            Console.WriteLine("Тип переменной numSbyteCLR: " + numSbyteCLR.GetType());

            byte numByte = default;
            Byte numByteCLR = default;
            Console.WriteLine("Тип переменной numByte: " + numByte.GetType());
            Console.WriteLine("Тип переменной numByteCLR: " + numByteCLR.GetType());

            short numShort = default;
            Int16 numShortCLR = default;
            Console.WriteLine("Тип переменной numShort: " + numShort.GetType());
            Console.WriteLine("Тип переменной numShortCLR: " + numShortCLR.GetType());

            int numInt = default;
            Int32 numIntCLR = default;
            Console.WriteLine("Тип переменной numInt: " + numInt.GetType());
            Console.WriteLine("Тип переменной numIntCLR: " + numIntCLR.GetType());

            long numLong = default;
            Int64 numLongCLR = default;
            Console.WriteLine("Тип переменной numLong: " + numLong.GetType());
            Console.WriteLine("Тип переменной numLongCLR: " + numLongCLR.GetType());

            ushort numUShort = default;
            UInt16 numUShortCLR = default;
            Console.WriteLine("Тип переменной numShort: " + numUShort.GetType());
            Console.WriteLine("Тип переменной numShortCLR: " + numUShortCLR.GetType());

            uint numUInt = default;
            UInt32 numUIntCLR = default;
            Console.WriteLine("Тип переменной numUInt: " + numUInt.GetType());
            Console.WriteLine("Тип переменной numUIntCLR: " + numUIntCLR.GetType());

            ulong numULong = default;
            UInt64 numULongCLR = default;
            Console.WriteLine("Тип переменной numULong: " + numULong.GetType());
            Console.WriteLine("Тип переменной numULongCLR: " + numULongCLR.GetType());

            float numFloat = default;
            Single numFloatCLR = default;
            Console.WriteLine("Тип переменной numFloat: " + numFloat.GetType());
            Console.WriteLine("Тип переменной numFloatCLR: " + numFloatCLR.GetType());

            decimal numDecimal = default;
            Decimal numDecimalCLR = default;
            Console.WriteLine("Тип переменной numDecimal: " + numDecimal.GetType());
            Console.WriteLine("Тип переменной numDecimalCLR: " + numDecimalCLR.GetType());

            char symbol = default;
            Char symbolCLR = default;
            Console.WriteLine("Тип переменной symbol: " + symbol.GetType());
            Console.WriteLine("Тип переменной symbolCLR: " + symbolCLR.GetType());

            string str = "Some string";
            String strCLR = "Another string";
            Console.WriteLine("Тип переменной str: " + str.GetType());
            Console.WriteLine("Тип переменной strCLR: " + strCLR.GetType());

            object obj = new object();
            Object objCLR = new object();
            Console.WriteLine("Тип переменной obj: " + obj.GetType());
            Console.WriteLine("Тип переменной objCLR: " + objCLR.GetType());
        }
    }
}
