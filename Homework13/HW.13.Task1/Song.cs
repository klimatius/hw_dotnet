using System.Collections;
using static HW._13.Task1.ISongService;
using Newtonsoft.Json;

namespace HW._13.Task1
{
    class Song : ISongService
    {
        string title;
        double songLengthMin;
        string author;
        int albumYear;
        Genre genre;
        FlagGenre fGenre;

        internal enum Genre
        {
            Rock = 0,
            Jazz = 1,
            Pop = 2,
            Metal = 3
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="songLengthMin"></param>
        /// <param name="author"></param>
        /// <param name="albumYear"></param>
        internal Song(string title, double songLengthMin, string author, int albumYear, string genre)
        {
            this.title = title;
            this.albumYear = albumYear;
            this.songLengthMin = songLengthMin;
            this.author = author;

            if (CheckGenre(genre))
            {
                Enum.TryParse(genre, out this.fGenre);
                Enum.TryParse(genre, out this.genre);
            }
            else
                {
                    this.fGenre = default;
                    this.genre = default;
                }
        }

        internal static bool CheckGenre(string checkGenre)
        {   
            Genre genre = new();
            if (!Enum.TryParse(checkGenre, out genre))
                return false;

            switch (genre)
            {
                case Genre.Rock:
                    return true;
                case Genre.Pop:
                    return true;
                case Genre.Jazz:
                    return true;
                case Genre.Metal:
                    return true;
                default:
                    return false;
            }
        }

        internal object GetSongData()
        {
            return new { Title = this.title, Minutes = this.songLengthMin, AlbumYear = this.albumYear };
        }

        //Newtonsoft.JSON
        internal static void NewtonSerialize(Song song)
        {
            Console.WriteLine("Json newton GetSongData:");
            string serializedNewton = JsonConvert.SerializeObject(song.GetSongData());
            Console.WriteLine(serializedNewton);
        }

        //Default JSON
        internal static void DefaultSerialize(Song song)
        {
            string serializedDefault = System.Text.Json.JsonSerializer.Serialize(song.GetSongData());
            Console.WriteLine("Json default GetSongData:");
            Console.WriteLine(serializedDefault);
        } 

        public static void SearchSongs(ArrayList songs, string genres)
        {
            foreach (Song song in songs)
            {
                ISongService.FlagGenre flagGenres;
                
                if (Enum.TryParse<ISongService.FlagGenre>(genres, out flagGenres) && flagGenres.HasFlag((Enum)song.fGenre))
                {
                    Console.WriteLine($"Name: {song.title}, author:{song.author}, length: {song.songLengthMin}, year: {song.albumYear}, genre: {song.genre}");
                }
            }
        }
    }
}
