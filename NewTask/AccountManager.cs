using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    public class AccountManager
    {
        public List<Account> Accounts { get; set; }
        public List<Account> SavingsAccounts { get; set; }
        public List<Account> CheckingAccounts { get;  set; }
        public List<Account> TrustAccounts { get; set; }

        public Dictionary<char, Func<string, double, Account>> AccountTypes { get; } = new Dictionary<char, Func<string, double, Account>>
    {
        {'A', (name, balance) => new Account(name, balance) },
        {'S', (name, balance) => new SavingsAccount(name, balance) },
        {'C', (name, balance) => new CheckingAccount(name, balance) },
        {'T', (name, balance) => new TrustAccount(name, balance) }
    };

        public AccountManager(List<Account> accounts, List<Account> savAccounts, List<Account> checAccounts, List<Account> trustAccounts)
        {
            Accounts = accounts;
            SavingsAccounts = savAccounts;
            CheckingAccounts = checAccounts;
            TrustAccounts = trustAccounts;
        }

        public void RegisterAccounts()
        {
            char input;
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You Want to Register a new Account? (y/n)");
                    Console.ResetColor();
                    input =char.ToLower(char.Parse(Console.ReadLine()));
                    if (input == 'y')
                    {
                        RegisterAccount();
                    }
                    else if (input != 'n')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please Enter only y or n !!!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Please enter only y or n, {ex.Message} !!");
                }
            }
        }

        public void RegisterAccount()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Please Enter your Name: ");
            Console.ResetColor();
            string name = Console.ReadLine();

            double balance = 1500;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\tYou will git a bonus of 1500$ after register!!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What type of account do you want?");
            Console.WriteLine("A - Normal Account \r\nS - Savings Account \r\nC - Checking Account \r\nT - Trust Account");
            Console.ResetColor();
            char TypeOfAccount = GetAccountType();

            var createAccount = AccountTypes[TypeOfAccount];
            var account = createAccount(name, balance);

            AddAccountToList(TypeOfAccount, account);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"** New account registered **\n" +
                          $"Name        : Mr. {name}\n" +
                          $"Account Type: {account.GetType().Name}\n" +
                          $"************************");
            Console.ResetColor();
        }

        public char GetAccountType()
        {
            while (true)
            {
                string temp = Console.ReadLine().ToUpper();
                if (temp.Length == 1 && "ASCT".Contains(temp))
                {
                    return temp[0];
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a single character (A, S, C, T):");
                }
            }
        }

        public void AddAccountToList(char TypeOfAccount, Account account)
        {
            //Accounts.Add(account);
            switch (TypeOfAccount)
            {
                case 'A':
                    Accounts.Add(account);
                    break;
                case 'S':
                    SavingsAccounts.Add(account);
                    break;
                case 'C':
                    CheckingAccounts.Add(account);
                    break;
                case 'T':
                    TrustAccounts.Add(account);
                    break;
            }
        }
    }


}
