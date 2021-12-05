using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task1
{
    internal class Person
    {
        internal int age;

        internal void Hello()
        {
            Console.WriteLine("Hello");
        }

        internal void SetAge(int n)
        {
            this.age = n;
        }
    }
}
