using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._13.Task2
{
    internal class MotorcycleNotFoundException : Exception
    {
        public MotorcycleNotFoundException(string message)
                    : base(message) { }
}
}
