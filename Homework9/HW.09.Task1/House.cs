using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1
{
    class House
    {
        public double Area { get; set; }
        public Door door;

        protected House(string color)
        {
            this.door = new();
            door.Color = color;
        }
        public House(double areaValue, string color)
        {
            this.Area = areaValue;
            this.door = new();
            door.Color = color;
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a house, my area is {this.Area} m2");
        }

        public void GetDoor()
        {
            Console.WriteLine($"Door color in the house {this.door.Color}");
        }

        public class Door
        {

            public string Color { get; set; }

            public void ShowData()
            {
                Console.WriteLine($"I am a door, my color is {this.Color}");
            }
        }

    }
}
