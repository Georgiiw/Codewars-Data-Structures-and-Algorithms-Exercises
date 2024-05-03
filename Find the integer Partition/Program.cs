namespace Find_the_integer_Partition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find the integer Partition of k-Length With Maximum or Minimum Value For Its Product Value

            //Test with random values
            foreach (var item in FindSpecPartition(134, 14, "max"))
            {
                Console.WriteLine(item);
            }
           

        }
        public static int[] FindSpecPartition(int number, int partitionNum, string com)
        {
            //Logic
            int[] partition = new int[partitionNum];

            if (com == "min")
            {
                partition[0] = number - partitionNum + 1;
                for (int i = 1; i < partitionNum; i++)
                {
                    partition[i] = 1;
                }
            }
            else if (com == "max")
            {
                int num = 0;
                while (true)
                {
                    for (int i = 0; i < partitionNum; i++)
                    {
                        partition[i]++;
                        num++;
                        if (num == number)
                        {
                            return partition;
                        }
                    }                   
                }
            }

            return partition;
        }
    }
}
