using System;

namespace Code_Sample_11_Method_return_with_plus
{
    class Program
    {
        static void Main()
        {
            int res;
            res = sillyReturnPlus(5);
            Console.WriteLine("res is : " + res);

            Console.Read();
        }
        static int sillyReturnPlus(int i)
        {
            i = i + 1;
            Console.WriteLine("i is : " + i);
            return i;
        }
    }
}
