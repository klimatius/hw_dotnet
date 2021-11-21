using System;

namespace HW._10.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new();
            Student student1 = new();
            Teacher teacher1 = new();

            student1.SetAge(21);
            student1.Hello();
            student1.ShowAge();

            teacher1.SetAge(30);
            teacher1.Hello();
            teacher1.Explain();
        }
    }
}
