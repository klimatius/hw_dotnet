using System;


namespace HW._10.Task2
{
    class Computer : Catalog
    {
        internal Computer(string name, string cathegory, string size)
        {
            this.cathegory = cathegory;
            this.name = name;
            this.code = Guid.NewGuid();
            this.size = size;
        }

        public override string ToString()
        {
            return $"Program: {this.name} \ncathegory: {this.cathegory} \nCode: {this.code}\nsize: {this.size}";
        }
    }
}
