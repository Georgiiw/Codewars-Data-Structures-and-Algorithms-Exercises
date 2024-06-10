namespace Range_Extraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A format for expressing an ordered list of integers is to use a comma separated list of either:
            // individual integers
            // or a range of integers denoted by the starting integer separated from the end integer
            // in the range by a dash, '-'. The range includes all integers in the interval including both endpoints.
            // It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"

            Console.WriteLine(Extract([-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10,
                11, 14, 15, 17, 18, 19, 20, 21, 22, 23, 26, 166]));
        }
        public static string Extract(int[] args)
        {
            string result = string.Empty;
            List<string> rangeResult = new List<string>();
            for (int i = 0; i <= args.Length - 1; i++)
            {
                if (i < args.Length - 1 && args[i] + 1 == args[i+1])
                {
                    rangeResult.Add($"{args[i]}");
                    continue;
                }
                else if(rangeResult.Count >= 2)
                {
                    result += $"{rangeResult[0]}-{args[i]},";
                    rangeResult.RemoveAll(n => n != "");
                }
                else
                {
                    foreach (var item in rangeResult)
                    {
                        result += $"{item},";
                    }
                    result += $"{args[i]},";
                    rangeResult.RemoveAll(n => n != "");
                }
            }
            return result.TrimEnd(','); 
        }
    }
}
