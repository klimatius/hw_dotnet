using System;
using System.Collections;

namespace HW._10.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Music song1 = new("singer1", 654, "song1", "rock", "5 mb");
            Music song2 = new("singer2", 655, "song2", "rock", "6 mb");
            ArrayList files = new ArrayList();
            files.Add(song1);
            files.Add(song2);

            Movies film1 = new("director1", "mainActor1", "mainActress1", "film1", "drama", "2 GB");
            Movies film2 = new("director2", "mainActor2", "mainActress2", "film2", "drama", "3 GB");
            Movies film3 = new("director3", "mainActor3", "mainActress3", "film3", "drama", "4 GB");
            files.Add(film1);
            files.Add(film2);
            files.Add(film3);


            Computer program1 = new("name1", "office", "10 GB");
            Computer program2 = new("name2", "office", "5 GB");
            Computer program3 = new("name3", "office", "6 GB");
            files.Add(program1);
            files.Add(program2);
            files.Add(program3);

            foreach (var item in files)
            {
                (item as Catalog).Play();
            }
        }
    }
}
