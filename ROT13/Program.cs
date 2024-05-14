using System.Text;

namespace ROT13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rot13("I love you."));
        }

        public static string Rot13(string input)
        {
            StringBuilder sb = new StringBuilder();
            List<char> list = new List<char>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz");
            List<char> rot13 = new List<char>("NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm");
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    int num = list.IndexOf(input[i]);
                    sb.Append(rot13[num]);                 
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            return sb.ToString();
        }
    }
}
