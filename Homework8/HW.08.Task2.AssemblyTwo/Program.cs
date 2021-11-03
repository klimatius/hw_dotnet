using HW._08.Task._2.AssemblyOne;
using System;

namespace HW._08.Task2.AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorCycle moto = new MotorCycle();
            Console.WriteLine(moto.publicField); //доступен всегда
            //Console.WriteLine(moto.internalField); //недоступен так как класс в другой сборке
            //Console.WriteLine(moto.protectedInternalField); //недоступен так как класс в другой сборке и не наследник

            //метод, константа и поле с модификатором private недоступны так как private доступен только в типе, в котором определён
            //метод, константа и поле с модификатором protected недоступны так как protected доступен только в типе, в котором определён и в наследниках
            //метод, константа и поле с модификатором private protected недоступны так как private protected доступен только в типе, в котором определён и в наследниках
        }    
    }

    class OffRoadBike : MotorCycle
    {
        void MainMethod()
        {
            Console.WriteLine(MotorCycle.protectedConst); //модификатор protected доступен так как наследник
            Console.WriteLine(MotorCycle.protectedInternalConst);//модификатор protected internal доступен так как находится в наследнике
            Console.WriteLine(MotorCycle.publicConst); //доступен везде
            //internal недоступны так как другая сборка
            //private недоступен так как это не исходный класс
            //private protected недоступны так как хоть и наследник но другая сборка
        }
    }
}
