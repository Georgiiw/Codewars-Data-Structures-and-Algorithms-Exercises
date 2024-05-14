using System.Runtime.CompilerServices;

namespace Pick_peaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a function that returns the positions and the values of the "peaks"
            // (or local maxima) of a numeric array.
            // For example, the array arr = [0, 1, 2, 5, 1, 0] has a peak at position 3
            // with a value of 5(since arr[3] equals 5).

            // Test
            int[] arr = { 7, 7, -1, 3, 7, 7, -3, 19, -2, -2, 13, -4, 13, 14, 17 };
            foreach (var item in GetPeaks(arr))
            {
                Console.WriteLine($"{item.Key}-{string.Join(" ", item.Value)}");
            }
        }

        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            Dictionary<string, List<int>> result = new Dictionary<string, List<int>>
            {
                { "pos", new List<int>() },
                { "peaks", new List<int>() }
            };
            bool left = false;
            bool right = false;

            // Logic
            for (int i = 1; i < arr.Length; i++)
            {
                if (i + 1 == arr.Length)
                {
                    break;
                }
                if (arr[i - 1] < arr[i] && arr[i + 1] < arr[i])
                {
                    result["pos"].Add(i);
                    result["peaks"].Add(arr[i]);
                }
                else if(arr[i + 1] == arr[i]|| arr[i - 1] == arr[i] && arr[i + 1] == arr[i])
                {
                    int pos = 0;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (arr[j] < arr[i])
                        {
                            pos = j + 1;
                            left = true;
                            break;
                        }
                        else if (arr[j] > arr[i])
                        {
                            break;
                        }
                    }
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (i + 2 == arr.Length)
                        {
                            break;
                        }
                        if (arr[j] < arr[i])
                        {
                            right = true;
                            break;
                        }
                        else if (arr[j] > arr[i] || arr[j + 1] == arr[i])
                        {
                            break;
                        }
                    }
                    if (left && right)
                    {
                        result["pos"].Add(pos);
                        result["peaks"].Add(arr[i]);
                    }
                    pos = 0;
                    left = false;
                    right = false;
                }               
            }

            return result;
        }
    }
}
