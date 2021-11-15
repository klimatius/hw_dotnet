using System;

namespace HW._09.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new (100, "red");
            house.ShowData();
            house.GetDoor();
            house.door.ShowData();

            Person person = new ("Vasya", 50, "blue");
            person.ShowData();

            Person person2 = new("Petya", 150, "green");
            person2.ShowData();
        }
    }
}
