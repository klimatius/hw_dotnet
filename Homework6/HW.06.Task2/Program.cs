using System;

namespace HW._06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " some s!tring 2222222 with 4444     words: 1111111           ";
            Console.WriteLine("Default string: " + str);
            Console.WriteLine(Program.SubMostLengthWord(str));
            Console.WriteLine(Program.ReplaceMostLengthWordWithMostShort(str));
            Program.HowMuchLetterAndSign(str);
            string[] sortedStringArray = Program.StringToArray(str);
            foreach(string tmp in sortedStringArray)
                Console.WriteLine(tmp);
        }

        static string SubMostLengthWord(string str)
        {
            string[] strArray = str.Split(new char[] { ' ' });
            int length = strArray.Length;
            string[][] keyArray = new string[length][];
            int[] lengthArray = new int[length];

            for (int i = 0; i < strArray.Length; i++)
            {   
                keyArray[i] = new string[2] { strArray[i].Length.ToString(), strArray[i] } ;
                lengthArray[i] = strArray[i].Length;
            }
            Array.Sort(lengthArray);

            int maxLength = lengthArray[length - 1];
            int count = 0;

            for (int i = length-1; i >= 0; i--)
            {
                if (lengthArray[i] == maxLength)
                    count++;
                else break;
            }

            for (int i = 0; i < length; i++)
            {
                if (Convert.ToInt32(keyArray[i][0]) == maxLength && count > 0)
                {
                    str = str.Remove(str.IndexOf(keyArray[i][1]), keyArray[i][1].Length);
                    count--;
                }       
            }

            string douleSpaceStr = "  ";
            while (str.IndexOf(douleSpaceStr) != -1)
            {
                str = str.Replace(douleSpaceStr, " ");
            }

            str = str.Trim();

            return str;
        }

        static string ReplaceMostLengthWordWithMostShort(string str)
        {
            string douleSpaceStr = "  ";
            while (str.IndexOf(douleSpaceStr) != -1)
            {
                str = str.Replace(douleSpaceStr, " ");
            }

            str = str.Trim();

            string[] strArray = str.Split(new char[] { ' ' });
            int length = strArray.Length;
            string[][] keyArray = new string[length][];
            int[] lengthArray = new int[length];

            for (int i = 0; i < strArray.Length; i++)
            {
                keyArray[i] = new string[2] { strArray[i].Length.ToString(), strArray[i] };
                lengthArray[i] = strArray[i].Length;       
            }

            Array.Sort(lengthArray);

            int maxLength = lengthArray[length - 1];
            int minLength = lengthArray[0];
            int countMax = 0, countMin = 0;

            for (int i = length - 1; i >= 0; i--)
            {
                if (lengthArray[i] == maxLength)
                    countMax++;
                if (lengthArray[i] == minLength)
                    countMin++;
            }

            if (countMax > 1)
            {
                for (int i = 0; i < length; i++)
                {
                    if (Convert.ToInt32(keyArray[i][0]) == maxLength && countMax > 1)
                    {
                        str = str.Remove(str.IndexOf(keyArray[i][1]), keyArray[i][1].Length);
                        keyArray[i] = null;
                        countMax--;
                    }
                }
            }

            if (countMin > 1)
            {
                for (int i = 0; i < length; i++)
                {
                    if (keyArray[i] != null && Convert.ToInt32(keyArray[i][0]) == minLength && countMin > 1)
                    {
                        str = str.Remove(str.IndexOf(keyArray[i][1]), keyArray[i][1].Length);
                        keyArray[i] = null;
                        countMin--;
                    }
                }
            }

            int minPos = 0, maxPos = 0;
            for (int i = length-1; i > 0; i--)
            {
                if (keyArray[i] != null && Convert.ToInt32(keyArray[i][0]) == minLength)
                {
                    minPos = i;
                }

                if (keyArray[i] != null && Convert.ToInt32(keyArray[i][0]) == maxLength)
                {
                    maxPos = i;
                }
            }

            string tempStr = keyArray[maxPos][1];
            keyArray[maxPos][1] = keyArray[minPos][1];
            keyArray[minPos][1] = tempStr;

            str = string.Empty;

            for (int i = 0; i < length; i++)
            {
                if (keyArray[i] != null && !String.IsNullOrWhiteSpace(keyArray[i][1]))
                    str = String.Concat(str, keyArray[i][1], " ");
            }

            str = str.Trim();

            return str;
        }

        static void HowMuchLetterAndSign(string str)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            int basicLength = str.Length;
            int spaceBarLength, letterLength, signLength;

            str = str.ToLower();
            str = str.Replace(" ", String.Empty);
            spaceBarLength = basicLength - str.Length;

            string[] strArr = str.Split(new char[] { ',', '.' ,'!', '?', ':', '\"', '-'});
            str = String.Empty;

            foreach(string tempStr in strArr)
                str = String.Concat(str, tempStr);

            signLength = basicLength - spaceBarLength - str.Length;
            Console.WriteLine("Number of signs: " + signLength);

            strArr = str.Split(letters);
            str = String.Empty;

            foreach (string tempStr in strArr)
                str = String.Concat(str, tempStr);

            letterLength = basicLength - spaceBarLength - signLength - str.Length;

            Console.WriteLine("Number of letters: " + letterLength);
        }

        static string[] StringToArray(string str)
        {
            string douleSpaceStr = "  ";
            while (str.IndexOf(douleSpaceStr) != -1)
            {
                str = str.Replace(douleSpaceStr, " ");
            }

            str = str.Trim();

            string[] strArray = str.Split(new char[] { ' ' });
            int length = strArray.Length;
            string[][] keyArray = new string[length][];
            int[] lengthArray = new int[length];

            for (int i = 0; i < strArray.Length; i++)
            {
                keyArray[i] = new string[2] { strArray[i].Length.ToString(), strArray[i] };
                lengthArray[i] = strArray[i].Length;
            }
            Array.Clear(strArray, 0, strArray.Length);
            Array.Sort(lengthArray);
            Array.Reverse(lengthArray);


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (keyArray[j] != null && Convert.ToInt32(keyArray[j][0]) == lengthArray[i])
                    {
                        strArray[i] = keyArray[j][1];
                        keyArray[j] = null;
                        break;
                    }
                }
            }

            return strArray;
        }
    }
}
