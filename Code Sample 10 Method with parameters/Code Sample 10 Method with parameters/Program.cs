using System;

namespace Code_Sample_10_Method_with_parameters
{
    class Program
    {
        static void Main()
        {
            silly(101);
            silly(500);

            Console.Read();
        }
        static void silly(int i)
        {
            Console.WriteLine("i is : " + i);
        }
    }
}
