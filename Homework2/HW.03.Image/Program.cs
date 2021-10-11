using System;
using System.IO;

namespace HW._03.Image
{
    class Program
    {
        static void Main(string[] args)
        {                          
            //Создание потока для считывания текста из файла
            StreamReader textReader = new StreamReader(@"C:\Users\klima\Desktop\image.txt", true);
            
            //Считывает все символы до конца потока и записывает в переменную в виде строки
            string textReaderResult = textReader.ReadToEnd();

            //Уничтожает поток
            textReader.Dispose();

            //Разбивает строку на массив подстрок удаляя пробелы
            string[] arrayOfTextResult = textReaderResult.Split(' ');

            //Создаёт массив данных типа byte длиной равной количеству строк предыдущего массива
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            
            //Цикл для обработки массива с бинарными данными
            for (int i = 0; i <arrayOfTextResult.Length - 1; i++)
            {
                //Конвертирует по очереди i-й элемент массива в байты в двоичной системе
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);

                //Записывает данные i-го элемента бинарного массива в i-й элемент конечного массива
                imageBytes[i] = binary;
            }

            //Создаёт изображение из данных
            File.WriteAllBytes(@"C:\Users\klima\Desktop\HW3.png", imageBytes);

            
        }
    }
}
