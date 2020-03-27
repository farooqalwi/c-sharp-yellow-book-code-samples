using System;

namespace Code_Sample_30_No_references_to_an_instance
{
    class Account
    {
        public string Name;
    }

    class Program
    {
        public static void Main()
        {
            Account RobsAccount;
            RobsAccount = new Account();
            RobsAccount.Name = "Rob";
            Console.WriteLine(RobsAccount.Name);
            RobsAccount = new Account();
            RobsAccount.Name = "Jim";
            Console.WriteLine(RobsAccount.Name);
        }
    }
}