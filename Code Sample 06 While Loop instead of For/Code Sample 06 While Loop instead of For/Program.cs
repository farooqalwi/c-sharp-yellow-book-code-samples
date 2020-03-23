using System;

namespace Code_Sample_06_While_Loop_instead_of_For
{
    class Program
    {
        static void Main()
        {
            int i;
            i = 1;
            while (i < 11)
            {
                Console.WriteLine("Hello mum");
                i = i + 1;
            }

            Console.Read();
        }
    }
}
