using System;

namespace Code_Sample_03_Casting_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3, j = 2;
            float fraction;
            fraction = (float)i / (float)j;
            Console.WriteLine("fraction : " + fraction);

            Console.Read();
        }
    }
}
