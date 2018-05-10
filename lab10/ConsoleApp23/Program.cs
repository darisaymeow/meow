using System;
using System.IO;

namespace ConsoleApp8

{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fstream = File.OpenRead(@"D:\note.txt"))
            {
                // преобразуем строку в байты
                byte[] str = new byte[fstream.Length];
                // считываем данные
                fstream.Read(str, 0, str.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(str);
                Console.WriteLine("Текст из файла: {0}", textFromFile);
                CapitalLetters capitalizer = new CapitalLetters();
                string result = capitalizer.ToCapital(textFromFile);
                Console.WriteLine($"После: {result}");
                StreamWriter sw = new StreamWriter(@"D:\output.txt");           
                sw.Write(result);
            sw.Close();
            }

            Console.ReadLine();
        }
    }
}