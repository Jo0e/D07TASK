using System.Security.Principal;

namespace NewTask

{
    internal class Program
    {
        static void Main()
        {
            #region CallingClasses
            var accounts = new List<Account>();
            var savAccounts = new List<Account>();
            var checAccounts = new List<Account>();
            var trustAccounts = new List<Account>();
            #endregion

            #region AccountRegister
            AccountManager accountManager = new AccountManager(accounts, savAccounts, checAccounts, trustAccounts);
            accountManager.RegisterAccounts();
            #endregion

            #region AllOfTheAccounts
            // Accounts
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\r\nAccount");
            AccountUtil.Display(accounts);
            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            savAccounts.Add(new SavingsAccount());
            savAccounts.Add(new SavingsAccount("Superman"));
            savAccounts.Add(new SavingsAccount("Batman", 2000));
            savAccounts.Add(new SavingsAccount("WonderWoman", 5000, 0.05));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\r\nSavings Account");
            AccountUtil.Display(savAccounts);
            AccountUtil.Deposit(savAccounts, 1000);
            AccountUtil.Withdraw(savAccounts, 2000);

            // Checking
            checAccounts.Add(new CheckingAccount());
            checAccounts.Add(new CheckingAccount("Larry2"));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\r\nChecking Account");
            AccountUtil.Display(checAccounts);
            AccountUtil.Deposit(checAccounts, 1000);
            AccountUtil.Withdraw(checAccounts, 2000);
            AccountUtil.Withdraw(checAccounts, 2000);

            // Trust
            trustAccounts.Add(new TrustAccount());
            trustAccounts.Add(new TrustAccount("Superman2"));
            trustAccounts.Add(new TrustAccount("Batman2", 2000));
            trustAccounts.Add(new TrustAccount("WonderWoman2", 5000, 0.05));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\r\nTrustAccount");
            AccountUtil.Display(trustAccounts);
            AccountUtil.Deposit(trustAccounts, 1000);
            AccountUtil.Deposit(trustAccounts, 6000);
            AccountUtil.Withdraw(trustAccounts, 2000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 500);
            Console.ResetColor();
            #endregion

            Console.WriteLine();
        }

    }
}
