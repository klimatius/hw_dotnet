

using System.Collections;

namespace HW._13.Task1
{
    internal interface ISongService
    {

        [Flags]
        internal enum FlagGenre
        {
            Rock = 1,
            Jazz = 2,
            Pop = 4,
            Metal = 8
        }

        static void SearchSongs(ArrayList songs, string genres) { }
    }
}
