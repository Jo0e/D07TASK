namespace NewTask
{
    public class CheckingAccount : Account
    {
        public double Fee {  get; set; }

        public CheckingAccount(string name = "Unnamed Account", double balance = 0, double fee = 1.5) : base(name, balance)
        {
            Fee = fee;
        }
        public override bool Withdraw(double amount)
        {
            if (Balance >= amount + Fee) 
            {
                Balance -= amount+ Fee;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}