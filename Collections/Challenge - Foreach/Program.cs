namespace Challenge___Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value:");
            string input = Console.ReadLine();
            Console.WriteLine("Select the Data type to validate the input you have entered.\nPress 1 for String\nPress 2 for Integer\nPress 3 for Boolean");
            int opt = 0;
            int.TryParse(Console.ReadLine(), out opt);
            switch (opt) {
                case 1:
                    if (IsValidString(input)) Console.WriteLine("Valid string");
                    else Console.WriteLine("Invalid String");
                    break;
                case 2:
                    if (IsValidInt(input)) Console.WriteLine("Valid integer");
                    else Console.WriteLine("Invalid integer");
                    break;
                case 3:
                    if (IsValidString(input)) Console.WriteLine("Valid boolean");
                    else Console.WriteLine("Invalid boolean");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        private static bool IsValidString(string str) { 
            foreach (char c in str)
            {
                if (!char.IsLetter(c)) return false;
            }
            return true;
        }

        private static bool IsValidInt(string str) {
            return int.TryParse(str, out int _int);
        }

        private static bool IsValidBool(string str)
        {
            return int.TryParse(str, out int _bool);
        }
    }
}