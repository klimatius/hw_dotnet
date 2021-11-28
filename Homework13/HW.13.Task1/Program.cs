// See https://aka.ms/new-console-template for more information
using HW._13.Task1;
using System.Collections;

Console.WriteLine("Enter genre:");
string songGenre = Console.ReadLine();
Song song1 = new("title1", 3.2, "author1", 2000, songGenre);
Song song2 = new("title2", 4, "author2", 2010, "Pop");
Song song3 = new("title3", 3, "author3", 2005, "Rock");
Song song4 = new("title4", 2, "author4", 2006, "Metal");
ArrayList songs = new();
songs.Add(song1);
songs.Add(song2);
songs.Add(song3);
songs.Add(song4);

Song.NewtonSerialize(song1);
Song.DefaultSerialize(song1);

Console.WriteLine("Enter song genres (Pop, Rock, Metal, Jazz)");
Song.SearchSongs(songs, Console.ReadLine());