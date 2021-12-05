using System;

namespace HW._10.Task2
{
    class Music : Catalog 
    {
        string singer;
        int secLength;

        internal  Music(string singer, int secLength, string name, string cathegory, string size)
        {
            this.singer = singer;
            this.secLength = secLength;
            this.cathegory = cathegory;
            this.name = name;
            this.code = Guid.NewGuid();
            this.size = size;
        }

        public override string ToString()
        {
            return $"Song: {this.name} \n singer: {this.singer} \n cathegory: {this.cathegory} \n Length {this.secLength} seconds \n" +
                $"Code: {this.code} \n size: {this.size}";
        }
    }
}
