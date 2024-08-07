namespace SecondSearchTask
{
    internal class ClsCalculator
    {
        internal static bool AreEqual<T>(T v1, T v2)
        {
            return EqualityComparer<T>.Default.Equals(v1, v2);
        }
    }
}
