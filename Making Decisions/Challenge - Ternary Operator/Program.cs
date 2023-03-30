using System.Runtime.CompilerServices;

namespace Challenge___Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = -10;

            while (true)
            {

                // TODO
                if (i == 11)
                {
                    Console.WriteLine(" FINAL BREAK REACHED! This should not happen!");
                    break;
                }
                if (i % 3 == 0)
                    i++;
                continue;
                Console.WriteLine(i++);
            }
        }

        static string GetMessage(int temp)
        {
            return temp < 16 ? "it is too cold here" : temp >= 16 && temp < 29 ? "it is ok" : "its hot here";

        }
    }
}