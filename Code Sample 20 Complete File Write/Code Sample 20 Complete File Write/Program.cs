using System;
using System.IO;

namespace Code_Sample_20_Complete_File_Write
{
    class Program
    {
        static void Main()
        {
            StreamWriter writer;
            writer = new StreamWriter("test.txt");
            writer.WriteLine("hello wrold");
            //writer.Close();

            Console.Read();
        }
    }
}
