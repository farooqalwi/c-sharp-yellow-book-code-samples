using System;

namespace Code_Sample_29_Multiple_References
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
            Account Temp;
            Temp = RobsAccount;
            Temp.Name = "Jim";
            Console.WriteLine(RobsAccount.Name);
        }
    }
}
