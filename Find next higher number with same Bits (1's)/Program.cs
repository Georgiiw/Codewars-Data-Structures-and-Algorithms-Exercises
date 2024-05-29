namespace Find_next_higher_number_with_same_Bits__1_s_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextHigher(128));
        }

        public static int NextHigher(int value)
        {
            int next = value + (value & -value);
            int rightOnesPattern = value ^ next;
            rightOnesPattern = (rightOnesPattern >> 2) / (value & -value);
            return next | rightOnesPattern;
        }     
    }
}
