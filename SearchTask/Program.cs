namespace SearchTask
{
    internal class Program
    {
        static void Main()
        {
            //bool IsEqual = ClsCalculator.AreEqual(10, 20);
            bool IsEqual = ClsCalculator.AreEqual("ABC", "ABC");
            //bool IsEqual = ClsCalculator.AreEqual(10.5, 20.5);

            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }

        }

    }

    internal class ClsCalculator
    {
        internal static bool AreEqual(string v1, string v2)
        {
            if (v1 == v2)
            {
                return true;
            }
            return false;
        }
    }
}
