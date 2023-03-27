using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Numerics;
using System.Xml.Linq;

namespace Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please enter your name and press enter");
            name = Console.ReadLine();
            Console.WriteLine("Upper: " + name.ToUpper());
            Console.WriteLine("Lower: " + name.ToLower());
            Console.WriteLine("Trimmed: " + name.Trim());
            Console.WriteLine("Substring: " + name.Substring(1));
        }
    }
}