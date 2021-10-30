using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._08.Task._2.AssemblyOne
{
    public class SportBike : MotorCycle
    {

        void SportBikeMethod()
        {
            Console.WriteLine(internalConst); //доступен так как в одной сборке
            Console.WriteLine(protectedConst); //доступен так как в наследнике
            Console.WriteLine(protectedInternalConst); //доступен так как в одной сборке
            Console.WriteLine(privateProtectedConst); //доступен так как наследник в одной сборке
            Console.WriteLine(publicConst); //доступен везде

            //метод, поле, и константа с модификатором private недоступны, т.к. private доступен только в исходном классе
        }
        
       
    }
}
