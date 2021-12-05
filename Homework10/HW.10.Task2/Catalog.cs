using System;

namespace HW._10.Task2
{
    class Catalog
    {
        internal string name;
        internal string cathegory;
        internal Guid code;
        internal string size;

        public void Play()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
