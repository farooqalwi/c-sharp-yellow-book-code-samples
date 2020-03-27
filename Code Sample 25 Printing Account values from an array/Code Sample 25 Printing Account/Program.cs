using System;

namespace Code_Sample_25_Printing_Account_values_from_an_array
{
    enum AccountState
    {
        New, Acitve, UnderAudit, Frozen, Closed
    }

    struct Account
    {
        public AccountState State;
        public string Name;
        public string Address;
        public int AccountNumber;
        public int Balance;
        public int Overdraft;
    };

    class Program
    {
        public static void PrintAccount(Account a)
        {
            Console.WriteLine("Name: " + a.Name);
            Console.WriteLine("Name: " + a.Address);
            Console.WriteLine("Name: " + a.Balance);
        }

        public static void Main()
        {
            const int MAX_CUST = 100;
            Account[] Bank = new Account[MAX_CUST];
            Bank[0].Name = "Rob";
            Bank[0].Address = "Rob's House";
            Bank[0].State = AccountState.Acitve;
            Bank[0].Balance = 1000000;
            PrintAccount(Bank[0]);
            Bank[1].Name = "Jim";
            Bank[1].Address = "Jim's House";
            Bank[1].State = AccountState.Frozen;
            Bank[1].Balance = 0;
            PrintAccount(Bank[1]);
        }
    }
}
