using System;
using System.Text;

namespace HW._08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("1a!2.3!!.. 4.!.?..6 7! ..?");
            sb = sb.Replace(" ", "_", sb.ToString().IndexOf('?'), sb.Length - sb.ToString().IndexOf('?'));
            sb = sb.Replace("!", string.Empty, 0, sb.ToString().IndexOf('?')).Replace(".", string.Empty, 0, sb.ToString().IndexOf('?'));
            Console.WriteLine(sb);
        }
    }
}
