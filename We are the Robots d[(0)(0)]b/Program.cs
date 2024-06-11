using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace We_are_the_Robots_d__0__0__b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Count the robots in the given array of strings, where some are "automatik" other "mechanik".
            // The pattern regex represents the valid robots 
            Console.WriteLine(string.Join(", ",CountRobots(["We're functioning automatik d[(0)(0)]b", "And we are dancing mechanik d[(0)(0)]b"])));
        }
        public static string[] CountRobots(string[] a)
        {          
            string pattern = @"[a-zA-Z][|};&#\[\]\/><()*]{2}0[|};&#\[\]\/><()*]{2}0[|};&#\[\]\/><()*]{2}[a-zA-Z]";
            string[] robots = new string[2];

            robots[0] = string.Join(" ", a.Where(s => Regex.IsMatch(s, pattern) && s.Contains("automatik", StringComparison.OrdinalIgnoreCase)));
            robots[1] = string.Join(" ", a.Where(s => Regex.IsMatch(s, pattern) && s.Contains("mechanik", StringComparison.OrdinalIgnoreCase)));

            string[] automatiks = robots[0]
                .Split(' ')
                .Where(r => r.Length > 6 && Regex.IsMatch(r, pattern))
                .ToArray();
          
            string[] mechaniks = robots[1]
                .Split(' ')
                .Where(r => r.Length > 6 && Regex.IsMatch(r, pattern))
                .ToArray();

            string[] result = { $"{automatiks.Length} robots functioning automatik", $"{mechaniks.Length} robots dancing mechanik" };
            
            return result;
        }
    }
}
