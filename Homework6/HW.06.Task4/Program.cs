using System;
using System.IO;
using System.Linq;

namespace HW._06.Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader textReader = new StreamReader(@"C:\Users\klima\Desktop\FindMe.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            textReader.Dispose();


            string invisibleSymbols = new string(textReaderResult.Where(c => char.IsControl(c)).ToArray());

            Console.WriteLine("Text has " + invisibleSymbols.Length + " unicode symbols");
            
            string[][] symArr = new string[invisibleSymbols.Length][];
            int arrLength = invisibleSymbols.Length;
            int stringLength = textReaderResult.Length;
            int counter = 0;
            string tmpstr = string.Empty;
            int index = -1;

            for (int i = 0; i < arrLength; i++)
            {
                for (int j = 0; j < stringLength; j++)
                {
                    index = textReaderResult.IndexOf(invisibleSymbols[i]);
                    if (index != -1)
                    {
                        counter++;
                        tmpstr += index + " ";
                        textReaderResult = textReaderResult.Remove(index, 1);
                    }

                }
                if (!string.IsNullOrEmpty(tmpstr))
                {
                    symArr[i] = new string[3] { tmpstr, Convert.ToInt32(invisibleSymbols[i]).ToString(), counter.ToString() };
                    tmpstr = string.Empty;
                    counter = 0;
                }
            }

            if(arrLength > 0)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    if(symArr[i] != null)
                    {
                        Console.WriteLine("Symbol " + symArr[i][1] + " counts " + symArr[i][2] + " times on positions " + symArr[i][0]);
                    }
                }
            }
            else Console.WriteLine("Text has no unicode symbols");
            
        }
    }
}
