namespace Code_Sample_23_Generous_Account_Structure
{
    enum AccountState
    {
        New, Acitve, UnderAudit, Frozen, Closed,
    }

    struct Account
    {
        public AccountState State;
        public string Name;
        public string Address;
        public int AccountNumber;
        public int Balance;
        public int Overdraft;
    }

    class Program
    {
        public static void Main()
        {
            Account RobsAccount;
            RobsAccount.State = AccountState.Acitve;
            RobsAccount.Balance = 1000000;
        }
    }
}
