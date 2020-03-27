using System;
using System.IO;

namespace Code_Sample_21_File_Write_and_Read
{
    class Program
    {
        public static void Main()
        {
            StreamWriter writer;
            writer = new StreamWriter("test.txt");
            writer.WriteLine("hello world");
            writer.Close();

            StreamReader reader = new StreamReader("test.txt");
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            reader.Close();
        }
    }
}
