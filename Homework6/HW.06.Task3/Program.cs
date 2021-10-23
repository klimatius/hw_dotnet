using System;

namespace HW._06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string defautlStr = "gdfgdf234dg54gf*23oP42";
            string mathStr = string.Empty;
            defautlStr = defautlStr.ToLower();
            char[] letters = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            string[] strArr = defautlStr.Split(letters);
            double totalValue = 0;
            int mathStrLength = default;
            bool flag = false;
            
            foreach(string str in strArr)
            {
                if (!String.IsNullOrEmpty(str))
                    mathStr = mathStr + str;
            }

            mathStrLength = mathStr.Length;

            try
            {
                if (mathStr.IndexOf('+') != -1 && mathStr.IndexOf('+') != 0 && mathStr.IndexOf('+') != mathStrLength - 1)
                {
                    totalValue = Convert.ToInt32(mathStr.Substring(0, mathStr.IndexOf('+'))) + Convert.ToInt32(mathStr.Substring(mathStr.IndexOf('+') + 1));
                    flag = true;
                }
                if (mathStr.IndexOf('-') != -1 && mathStr.IndexOf('-') != 0 && mathStr.IndexOf('-') != mathStrLength - 1)
                {
                    totalValue = Convert.ToInt32(mathStr.Substring(0, mathStr.IndexOf('-'))) - Convert.ToInt32(mathStr.Substring(mathStr.IndexOf('-') + 1));
                    flag = true;
                }
                if (mathStr.IndexOf('*') != -1 && mathStr.IndexOf('*') != 0 && mathStr.IndexOf('*') != mathStrLength - 1)
                {
                    totalValue = Convert.ToInt32(mathStr.Substring(0, mathStr.IndexOf('*'))) * Convert.ToInt32(mathStr.Substring(mathStr.IndexOf('*') + 1));
                    flag = true;
                }
                if (mathStr.IndexOf('/') != -1 && mathStr.IndexOf('/') != 0 && mathStr.IndexOf('/') != mathStrLength - 1)
                {
                    if (Convert.ToInt32(mathStr.Substring(mathStr.IndexOf('/') + 1)) != 0)
                    {
                        totalValue = Convert.ToInt32(mathStr.Substring(0, mathStr.IndexOf('/'))) / Convert.ToInt32(mathStr.Substring(mathStr.IndexOf('/') + 1));
                        flag = true;
                    }
                    else Console.WriteLine("Divine on 0 = infinite");

                }
                if (flag)
                {
                    Console.Write(mathStr);
                    Console.WriteLine("=" + totalValue);
                }
                else Console.WriteLine("Something wrong with string");
            }
            catch
            {
                Console.WriteLine("Something wrong with string");
            }
        }
    }
}
