using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1
{
    class Person
    {
        public string Name { get; set; }
        House house;
        SmallApartment smallApartment;
        
        public Person (string name, double area, string doorColor)
        {
            this.Name = name;
            if (area == 50)
                smallApartment = new(doorColor);
            else house = new House(area, doorColor);
        }

        public void ShowData()
        {
            Console.WriteLine($"Persons name {this.Name}");
            if (this.house != null)
            {
                this.house.ShowData();
                this.house.GetDoor();
            }
            else
            {
                this.smallApartment.ShowData();
                this.smallApartment.GetDoor();
            }
        }
    }
}
