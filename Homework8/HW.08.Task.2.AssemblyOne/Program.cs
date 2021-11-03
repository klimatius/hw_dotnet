using System;

namespace HW._08.Task._2.AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorCycle moto = new MotorCycle();
            Console.WriteLine(moto.publicField); //доступен всегда
            Console.WriteLine(moto.internalField); //доступен так как в одной сборке
            Console.WriteLine(moto.protectedInternalField); //доступен так как в одной сборке

            //метод, константа и поле с модификатором private недоступны так как private доступен только в типе, в котором определён
            //метод, константа и поле с модификатором protected недоступны так как protected доступен только в типе, в котором определён и в наследниках
            //метод, константа и поле с модификатором private protected недоступны так как private protected доступен только в типе, в котором определён и в наследниках

            Console.WriteLine(MotorCycle.internalConst);
            Console.WriteLine(MotorCycle.protectedInternalConst);
            Console.WriteLine(MotorCycle.publicConst);

            moto.PublicMethod();
            moto.InternalMethod();
            moto.ProtectedInternalMethod();

            SportBike sportBike1 = new SportBike();
            Console.WriteLine(SportBike.internalConst);
            Console.WriteLine(SportBike.protectedInternalConst);
            Console.WriteLine(SportBike.publicConst);

            Console.WriteLine(sportBike1.publicField);
            Console.WriteLine(sportBike1.internalField);
            Console.WriteLine(sportBike1.protectedInternalField);

            sportBike1.PublicMethod();
            sportBike1.InternalMethod();
            sportBike1.ProtectedInternalMethod();
        }
    }
}
