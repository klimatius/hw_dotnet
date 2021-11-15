using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task1
{
    class SmallApartment : House
    {
        public SmallApartment(string color) : base(color)
        {
            this.Area = 50;
            this.door.Color = color;
        }
    }
}
