using System.Runtime.CompilerServices;

namespace Challenge___Parse_Game_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines =  File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "input.txt"));

            foreach (string line in lines) {
                if (line.Contains("split")) {
                    Console.Write(line.Split()[4] + " ");
                }
            }
        }
    }
}