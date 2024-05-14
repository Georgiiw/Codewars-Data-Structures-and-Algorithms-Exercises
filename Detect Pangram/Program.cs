namespace Detect_Pangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPangram("abcdefghywyreyijkltretetmnopqrfdsfstuvwxyzxzxzx"));
           
        }
        public static bool IsPangram(string str)
        {
            List<char> list = new List<char>("abcdefghijklmnopqrstuvwxyz");
            for (int i = 0; i < list.Count; i++)
            {
                if (str.ToCharArray().Any(x => x == list[i]))
                {
                    list.Remove(list[i]);
                    i--;
                }
            }
            return list.Count == 0;
        }
    }
}
