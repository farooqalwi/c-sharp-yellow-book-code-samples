using System;

namespace Code_Sample_28_Compiling_Account_Class
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
        }
    }
}
