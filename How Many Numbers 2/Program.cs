namespace How_Many_Numbers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test 
            foreach (var item in MaxSumDig(5000, 6))
            {
                Console.WriteLine(item);
            }
        }
        public static long[] MaxSumDig(long nmax, int maxsm)
        {
            long[] arr = new long[3];
            //Logic
            List<long> foundNumbers = new List<long>();

            for (int i = 1000; i <= nmax; i++)
            {
                int num = i.ToString().Sum(x => x - '0');
                if (num <= maxsm)
                {
                    foundNumbers.Add(i);
                }
            }
            long sumOfNumbers = foundNumbers.Sum();
            long mean = sumOfNumbers / foundNumbers.Count(); 
            long closest = mean - foundNumbers[0];
            arr[0] = foundNumbers.Count();
            arr[2] = sumOfNumbers;
            foreach (var item in foundNumbers)
            {
                if (Math.Abs(mean - item) <= closest)
                {
                    closest = Math.Abs(mean - item);
                    arr[1] = item;
                }
            }

            return arr;
        }
    }
}
