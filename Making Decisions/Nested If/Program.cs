namespace Nested_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRegistered = true;
            string userName = "";
            bool isAdmin = true;

            Console.WriteLine("Please enter you username");
            userName = Console.ReadLine();

            if (isRegistered && userName != "" && isAdmin)
            {
                Console.WriteLine("User is registered");
                Console.WriteLine("Hello {0}", userName);
                Console.WriteLine("Oh, an Admin logged in. Welcome");

                if (userName == "Caleb")
                {
                    Console.WriteLine("Welcome, Master Caleb");
                }
            }

        }
    }
}