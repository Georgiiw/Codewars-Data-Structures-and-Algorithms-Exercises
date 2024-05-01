using System.Text;

namespace Decode_the_Morse_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> table = new Dictionary<string, string>();
            LoadMorseTable(table);

            string morseCode = Console.ReadLine();
            string[] msg = morseCode.Split("  ");


            StringBuilder result = new StringBuilder();
            foreach (string word in msg)
            {
                string[] letters = word.Split(' ');
                string currWord = string.Empty;
                foreach (var character in letters)
                {
                    if (table.ContainsKey(character))
                    {
                        currWord += table[character];
                    }
                }
                result.Append(currWord + " ");
            }
            Console.WriteLine(result.ToString().TrimStart().TrimEnd());          
        }

        private static void LoadMorseTable(Dictionary<string, string> table)
        {
            table.Add(".-", "A");
            table.Add("-...", "B");
            table.Add("-.-.", "C");
            table.Add("-..", "D");
            table.Add(".", "E");
            table.Add("..-.", "F");
            table.Add("--.", "G");
            table.Add("....", "H");
            table.Add("..", "I");
            table.Add(".---", "J");
            table.Add("-.-", "K");
            table.Add(".-..", "L");
            table.Add("--", "M");
            table.Add("-.", "N");
            table.Add("---", "O");
            table.Add(".--.", "P");
            table.Add("--.-", "Q");
            table.Add(".-.", "R");
            table.Add("...", "S");
            table.Add("-", "T");
            table.Add("..-", "U");
            table.Add("...-", "V");
            table.Add(".--", "W");
            table.Add("-..-", "X");
            table.Add("-.--", "Y");
            table.Add("--..", "Z");
            table.Add("...---...", "SOS");
            table.Add("-.-.--", "!");
            table.Add("..--..", "?");
            table.Add(".-.-.-", ".");

        }
    }
}
