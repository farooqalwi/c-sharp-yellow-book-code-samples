using System;

namespace Code_Sample_42_ToString_method
{
    class Account
    {
        private string name;
        private decimal balance;

        public override string ToString()
        {
            return "Name: " + name + " balance: " + balance;
        }
        public Account(string inName, decimal inBalance)
        {
            name = inName;
            balance = inBalance;
        }
    }

    class Program
    {
        static void Main()
        {
            Account a = new Account("Rob", 25);
            Console.WriteLine(a);
        }
    }
}
