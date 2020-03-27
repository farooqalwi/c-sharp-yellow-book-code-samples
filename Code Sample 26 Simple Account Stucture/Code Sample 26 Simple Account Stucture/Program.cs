using System;

namespace Code_Sample_26_Simple_Account_Stucture
{
    struct AccountStruct
    {
        public string Name;
    }

    class Program
    {
        public static void Main()
        {
            AccountStruct RobsAccountStruct;
            RobsAccountStruct.Name = "Rob";
            Console.WriteLine(RobsAccountStruct.Name);
        }
    }
}
