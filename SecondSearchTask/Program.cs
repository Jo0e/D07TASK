using System.Security.Principal;

namespace SecondSearchTask
{
    internal class Program
    {
        static void Main()
        {
            //var e = Console.ReadKey();
            //bool IsEqual = ClsCalculator.AreEqual<int>(10, 20);
            //bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
            //bool IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);
            bool IsEqual = ClsCalculator.AreEqual<Account>(new(1, "you"), new(1, "you"));


            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();
        }
    }
}
