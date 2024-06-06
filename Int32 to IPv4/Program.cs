using System.Net;

namespace Int32_to_IPv4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UInt32ToIP(2154959208));
        }
        public static string UInt32ToIP(uint ip)
        {         
            return $"{IPAddress.Parse($"{ip}")}";
        }
    }
}
