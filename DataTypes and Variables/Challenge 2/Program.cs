using System.Transactions;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string here: ");
            string inputString  =  Console.ReadLine();
            Console.WriteLine("Enter the character to search: ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine("\nIndex of given char: " + inputString.IndexOf(inputChar));

            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string lastName = Console.ReadLine();
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName);
        }
    }
}