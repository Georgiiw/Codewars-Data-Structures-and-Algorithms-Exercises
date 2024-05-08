namespace Maximum_subarray_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The maximum sum subarray problem consists in finding the maximum sum of a
            // contiguous subsequence in an array or list of integers:

            // Test
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(MaxSequence(arr));
        }

        public static int MaxSequence(int[] arr)
        {
            int maxNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = 0;
                for (int j = 0; j < arr.Length - i; j++)
                {
                    currNum += arr[i + j];
                    if (currNum > maxNum)
                    {
                        maxNum = currNum;
                    }
                }
            }
            return maxNum;
        }
    }
}
