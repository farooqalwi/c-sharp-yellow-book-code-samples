using System;

namespace Code_Sample_31_Withdraw_insufficient_funds
{
    class Account
    {
        private decimal balance = 0;

        public bool WithdrawFunds(decimal amount)
        {
            if (balance<amount)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }
    }

    class Program
    {
        static void Main()
        {
            Account RobsAccount;
            RobsAccount = new Account();
            if (RobsAccount.WithdrawFunds(5))
            {
                Console.WriteLine("Cash Withdrawn");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
    }
}
