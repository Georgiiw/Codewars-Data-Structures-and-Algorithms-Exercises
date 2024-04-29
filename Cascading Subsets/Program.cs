using System.Text;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method each_cons that accepts a list and a number n,
            //and returns cascading subsets of the list of size n, like so:
            
            //    each_cons([1, 2, 3, 4], 2)
            //    #=> [[1,2], [2,3], [3,4]]

            //    each_cons([1, 2, 3, 4], 3)
            //    #=> [[1,2,3],[2,3,4]]

            int[] nums = Console.ReadLine().Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            int num = int.Parse(Console.ReadLine());

            EachCons(nums, num);

        }
        public static void EachCons(int[] nums, int num)
        {
            //Logic
            List<int[]> list = new List<int[]>();
            if (num <= nums.Length)
            {
                for (int i = 0; i <= nums.Length - num; i++)
                {
                    int[] arr = new int[num];
                    for (int j = 0; j < num; j++)
                    {
                        arr[j] += nums[i + j];
                    }
                    list.Add(arr);
                }
            }

            //Print result
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    Console.Write($"{list[i][j]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
