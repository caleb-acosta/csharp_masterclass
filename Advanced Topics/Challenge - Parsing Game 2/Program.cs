using System.Text.RegularExpressions;

namespace Challenge___Parsing_Game_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secreFile = File.ReadAllText(@"input2.txt");

            Regex rx = new Regex(@"\d{2,3}",
              RegexOptions.Compiled);

            MatchCollection matches = rx.Matches(secreFile);

            foreach (Match match in matches)
            {
                Console.Write((char) int.Parse(match.Value));
            }
        }
    }
}