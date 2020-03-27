using System;

namespace Code_Sample_27_Non_compiling_Account_class
{
    class Account
    {
        public string Name;
    }

    class Program
    {
        public static void Main()
        {
            Account RobsAccount = new Account();
            RobsAccount.Name = "Rob";
            Console.WriteLine(RobsAccount.Name);
        }
    }
}
