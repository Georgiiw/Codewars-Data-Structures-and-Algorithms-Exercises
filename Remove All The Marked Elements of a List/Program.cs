namespace Remove_All_The_Marked_Elements_of_a_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define a method/function that removes from a given array of integers
            //all the values contained in a second array.

            int[] arrOne = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] arrTwo = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            CleanArray(arrOne, arrTwo);
        }

        private static void CleanArray(int[] integerArr, int[] valuesArr)
        {
            //Logic
            int[] result = integerArr.Where(x => !valuesArr.Contains(x)).ToArray();

            //List<int> list = new List<int>();
            //for (int i = 0; i < integerArr.Length; i++)
            //{
            //    list.Add(integerArr[i]);
            //}
            //for (int i = 0; i < valuesArr.Length; i++)
            //{
            //    for (int j = 0; j < list.Count; j++)
            //    {
            //        if (list[j] == valuesArr[i])
            //        {
            //            list.RemoveAt(j);
            //            j--;
            //        }
            //    }
            //}
            //int[] result = list.ToArray();

            //Print result
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"{result[i]} ");
            }

        }
    }
}
