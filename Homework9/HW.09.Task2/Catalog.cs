using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task2
{
    public class Catalog
    {
        string name;
        string cathegory;
        Guid code;
        string size;

        public class Music
        {
            Catalog catalog = new();
            string singer;
            int secLength;

            public Music(string singer, int secLength, string name, string cathegory, string size, Guid code)
            {
                this.singer = singer;
                this.secLength = secLength;
                this.catalog.cathegory = cathegory;
                this.catalog.name = name;
                this.catalog.code = code;
                this.catalog.size = size;
            }

            public override string ToString()
            {
                return $"Song: {catalog.name} \n singer: {this.singer} \n cathegory: {catalog.cathegory} \n Length {this.secLength} seconds \n" +
                    $"Code: {catalog.code} \n size: {catalog.size}";
            }

            public void Play()
            {
                Console.WriteLine(this.ToString());
            }
        }

        public class Movie
        {
            Catalog catalog = new();
            string director;
            string mainActor;
            string mainActress;

            public Movie(string director, string mainActor, string mainActress, string name, string cathegory, string size, Guid code)
            {
                this.director = director;
                this.mainActor = mainActor;
                this.mainActress = mainActress;
                this.catalog.cathegory = cathegory;
                this.catalog.name = name;
                this.catalog.code = code;
                this.catalog.size = size;
            }
            public override string ToString()
            {
                return $"Movie: {catalog.name} \ndirector: {this.director} \ncathegory: {catalog.cathegory} \nMain Actor {this.mainActor}\n" +
                    $"Main Actress {this.mainActress}\nCode: {catalog.code}\nsize: {catalog.size}";
            }

            public void Play()
            {
                Console.WriteLine(this.ToString());
            }
        }

        public class PCProgram
        {
            Catalog catalog = new();

            public PCProgram(string name, string cathegory, string size, Guid code)
            {
                this.catalog.cathegory = cathegory;
                this.catalog.name = name;
                this.catalog.code = code;
                this.catalog.size = size;
            }
        }
    }
}
