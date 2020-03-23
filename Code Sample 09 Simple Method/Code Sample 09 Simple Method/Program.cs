using System;

namespace Code_Sample_09_Simple_Method
{
    class Program
    {
        public static void Main()
        {
            doit();
            doit();

            Console.Read();
        }

        static void doit()
        {
            Console.WriteLine("Hello");
        }
    }
}
