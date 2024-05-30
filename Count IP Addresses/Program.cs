namespace Count_IP_Addresses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IpsBetween("20.0.50.00", "20.1.0.00"));
        }
        public static long IpsBetween(string start, string end)
        {
            string[] first = start.Split('.');
            string[] second = end.Split('.');
            long counter = 0;

            for (int i = 0; i < 4; i++)
            {
                long startValue = long.Parse(first[i]);
                long endValue = long.Parse(second[i]);

                counter += (endValue - startValue) * (long)Math.Pow(256, 3 - i);
            }

            return counter;
        }
    }
}
