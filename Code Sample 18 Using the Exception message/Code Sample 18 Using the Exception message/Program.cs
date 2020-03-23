using System;

namespace Code_Sample_18_Simple_Exception_Catching
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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
