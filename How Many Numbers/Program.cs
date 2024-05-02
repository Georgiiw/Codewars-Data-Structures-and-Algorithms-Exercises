namespace How_Many_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SelNumber(100, 3));
            
        }
        public static int SelNumber(int number, int excessor)
        {
            int counter = 0;

            //Logic
            for (int i = 0; i <= number; i++)
            {
                bool pass = false;            
                string[] num = i.ToString().Select(d => d.ToString()).ToArray();
                for (int j = 0; j < num.Length - 1; j++)
                {
                    int currNum = int.Parse(num[j]);
                    int NextNum = int.Parse(num[j + 1]);
                    if (currNum == NextNum || currNum > NextNum || NextNum - currNum > excessor)
                    {
                        pass = false;
                        break;
                    }
                    if (NextNum - currNum <= excessor)
                    {
                        pass = true;
                    }
                }
                if (pass)
                {
                    counter++;
                }

            }
            return counter;
        }
    }
}
