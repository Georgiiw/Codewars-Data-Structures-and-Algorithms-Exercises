using System.Numerics;

namespace Simple_number_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(82));
        }
        public static BigInteger Solve(int num)
        {
            BigInteger result = 0;
            List<List<BigInteger>> lists = new List<List<BigInteger>>(num);
            for (int i = 0; i < num; i++)
            {
                lists.Add(new List<BigInteger>());
            }
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        if (i == num - 1)
                        {
                            result += 1;
                        }
                        lists[i].Add(1);
                        continue;
                    }
                    BigInteger left = lists[i][j - 1];
                    if (j < i)
                    {
                        BigInteger up = lists[i - 1][j];
                        lists[i].Add( up + left);
                    }
                    else
                    {
                        lists[i].Add(left);
                    }
                    if(i == num - 1)
                    {
                        result += lists[i][j];
                    }
                }         
            }
            return result;
        }     
    }
}
