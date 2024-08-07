namespace NewTask
{
    public class TrustAccount : SavingsAccount
    {
            int WithdrawCount { get; set; }
            DateTime WithdrawYear { get; set; } 

        public TrustAccount(string name = "Unnamed Account", double balance = 0, double interestRate = 0, int withdrawCount = 0, DateTime withdrawYear = default) : base(name, balance)
        {
            WithdrawCount = withdrawCount;
            WithdrawYear = withdrawYear ;
        }


        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
            {
                Balance += 50;
                base.Deposit(amount);
                return true;
            }
            else if (amount < 5000)
            {
                base.Deposit(amount);
                return true;
            }
            return false;
        }


        public override bool Withdraw(double amount)
        {
            if (DateTime.Now.Year != WithdrawYear.Year)
            {
                WithdrawCount = 0;
                WithdrawYear = DateTime.Now;
            }
            if (WithdrawCount == 3)
            {
                return false;
            }
            if (amount < Balance * 0.2) 
            { 
                Balance -= amount;
                WithdrawCount++;
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}