namespace NewTask
{
    public class SavingsAccount : Account
    {
        double InterestRate { get; set; }


        public SavingsAccount(string name = "Unnamed Account", double balance = 0, double interestRate = 0) : base(name, balance)
        {
            InterestRate = interestRate;
        }
        public override bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                Balance += amount * InterestRate;
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }

}