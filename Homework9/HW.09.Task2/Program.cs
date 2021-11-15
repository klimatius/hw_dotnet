using System;
using System.Collections;
using static HW._09.Task2.Catalog;

namespace HW._09.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Music song1 = new("singer", 654, "song", "rock", "5 mb", Guid.NewGuid());
            Music song2 = new("singer2", 655, "song2", "rock", "6 mb", Guid.NewGuid());
            ArrayList songs = new ArrayList();
            songs.Add(song1);
            songs.Add(song2);
            song1.Play();

            Movie film1 = new("director1", "mainActor1", "mainActress1", "film1", "drama", "2 GB",Guid.NewGuid());
            Movie film2 = new("director2", "mainActor2", "mainActress2", "film2", "drama", "3 GB", Guid.NewGuid());
            Movie film3 = new("director3", "mainActor3", "mainActress3", "film3", "drama", "4 GB", Guid.NewGuid());
            ArrayList movies = new ArrayList();
            movies.Add(film1);
            movies.Add(film2);
            movies.Add(film3);
            film1.Play();

            PCProgram program1 = new("name1", "office", "10 GB", Guid.NewGuid());
            PCProgram program2 = new("name2", "office", "5 GB", Guid.NewGuid());
            PCProgram program3 = new("name3", "office", "6 GB", Guid.NewGuid());
            ArrayList programs = new ArrayList();
            programs.Add(program1);
            programs.Add(program2);
            programs.Add(program3);
        }
    }
}
