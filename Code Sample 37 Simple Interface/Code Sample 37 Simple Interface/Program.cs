using System;

namespace Code_Sample_37_Simple_Interface
{
    public interface IAccount
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }

    public class CustomerAccount : IAccount
    {
        private decimal balance = 0;

        public bool WithdrawFunds(decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }

        public void PayInFunds(decimal amount)
        {
            balance = balance + amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main()
        {
            IAccount account = new CustomerAccount();
            account.PayInFunds(50);
            Console.WriteLine("Balance: " + account.GetBalance());
        }
    }
}
