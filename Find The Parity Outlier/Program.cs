namespace Find_The_Parity_Outlier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = new int[] { 1, 15, 3, 5, 7, 9, 12 };
            Console.WriteLine(Find(integers));
        }

        public static int Find(int[] integers)
        {
           int count = integers.Count(n => n % 2 == 0);

            return count > 1 ? integers.First(n => n % 2 == 1) : integers.First(n => n % 2 == 0);
        }
    }
}
