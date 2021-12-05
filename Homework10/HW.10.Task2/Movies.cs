using System;

namespace HW._10.Task2
{
    class Movies : Catalog
    {
        string director;
        string mainActor;
        string mainActress;

        internal Movies(string director, string mainActor, string mainActress, string name, string cathegory, string size)
        {
            this.director = director;
            this.mainActor = mainActor;
            this.mainActress = mainActress;
            this.cathegory = cathegory;
            this.name = name;
            this.code = Guid.NewGuid();
            this.size = size;
        }

        public override string ToString()
        {
            return $"Movie: {this.name} \ndirector: {this.director} \ncathegory: {this.cathegory} \nMain Actor {this.mainActor}\n" +
                $"Main Actress {this.mainActress}\nCode: {this.code}\nsize: {this.size}";
        }
    }
}
