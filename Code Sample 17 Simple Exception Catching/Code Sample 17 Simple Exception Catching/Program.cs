using System;

namespace Code_Sample_17_Simple_Exception_Catching
{
    class Program
    {
        static void Main()
        {
            int age;
            Console.Write("Enter your age: ");
            string ageString = Console.ReadLine();

            try
            {
                age = int.Parse(ageString);
                Console.WriteLine("Thank you");
            }
            catch
            {
                Console.WriteLine("Invalid age value");
            }
        }
    }
}
