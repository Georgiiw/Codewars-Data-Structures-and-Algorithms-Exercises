using System.Numerics;

namespace Perimeter_of_squares_in_a_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Could you give the sum of the perimeters of all the squares in a rectangle when there are n + 1 squares
            // where every square has a side the next number in the Fibonacci sequence : for n = 5 -> 4 *(1+1+2+3+5+8).
            Console.WriteLine(Perimeter(5));
        }
        public static BigInteger Perimeter(BigInteger n)
        {
            BigInteger a = 0, b = 1, c = 0;
            BigInteger result = 4;
            for (int i = 1; i < n + 1; i++)
            {
                c = a + b;
                result += c * 4;
                a = b;
                b = c;
            }

            return result;
        }
    }
}
