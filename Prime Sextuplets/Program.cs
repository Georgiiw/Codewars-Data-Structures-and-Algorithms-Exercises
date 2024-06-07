namespace Prime_Sextuplets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We are interested in collecting the sets of six prime numbers, that having a starting prime p,
            // the following values are also primes forming the sextuplet [p, p + 4, p + 6, p + 10, p + 12, p + 16]
            // 10000 < sumLimit < 29700000
            Console.WriteLine(string.Join(",", FindPrimeSextuplet(29700000)));
            
        }
        public static int[] FindPrimeSextuplet(int sumLimit)
        {
            bool found = false;
            int first = sumLimit / 12;
            if (first % 2 == 0)
            {
                first++;
            }
            while (!found) 
            {

                int[] result = { first, first + 4, first + 6, first + 10, first + 12, first + 16 };
                if (result.All(n => IsPrime(n) == true) && result.Sum() > sumLimit)
                {
                    return result;
                }
                first += 2;
            }
            return new int[0];
        }
        public static bool IsPrime(int num)
        {
            bool prime = true;
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
    }
}
