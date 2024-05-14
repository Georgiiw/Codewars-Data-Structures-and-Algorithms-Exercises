using System.Text;

namespace Banana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> result = new HashSet<string>();
            foreach (var item in GetStrings("bbaannana", 1, result))
            {
                Console.WriteLine(item);
            }      
        }
        //public static HashSet<string> Bananas(string s)
        //{
        //    HashSet<string> result = new HashSet<string>();
        //    int counter = 1;
        //    foreach (var item in GetStrings(s, counter))
        //    {
        //        result.Add(item);
        //    }
            
        //    return result;
        //}

        public static HashSet<string> GetStrings(string str, int counter, HashSet<string> res)
        {
            StringBuilder sb = new StringBuilder(str);
            HashSet<string> result = new HashSet<string>();
            string currentStr = "";
            string lastIndex = "";
       
                for (int j = 0; j < sb.Length; j++)
                {
                    if (lastIndex == "banana")
                    {
                        currentStr += '-';
                        continue;
                    }
                    if (sb[j] == 'b' && currentStr == "" || currentStr.All(x => x != 'b'))
                    {
                        currentStr += sb[j];
                        if (sb[j] == 'b')
                            lastIndex += 'b';
                    }
                    else if (sb[j] == 'a' && lastIndex.Last() != 'a')
                    {
                        currentStr += sb[j];
                        lastIndex += sb[j];
                    }
                    else if (sb[j] == 'n' && lastIndex.Last() == 'a')
                    {
                        currentStr += sb[j];
                        lastIndex += sb[j];
                    }
                    else
                    {
                        currentStr += '-';
                    }
                }
                result.Add(currentStr);
                sb[counter - 1] = '-';
           

            if (counter == sb.Length)
            {
                return result;
            }
            return GetStrings(sb.ToString(), counter + 1, result);
        }
    }
}
