namespace If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRegistered = true;
            string userName = "";
            bool isAdmin = true;

            //User-Input
            Console.WriteLine("Please enter you username");
            userName = Console.ReadLine();

            //Code inside will be executed, if isRegistered is true
            if (isRegistered)
            {
                Console.WriteLine("User is registered");

                //Code inside will be executed, if userName is not ""
                if (userName != "")
                {
                    Console.WriteLine("Hello {0}", userName);

                    //Code inside will be executed, if userName is "Mike"
                    if (isAdmin)
                    {
                        Console.WriteLine("Oh, an Admin logged in. Welcome");
                    }
                }
            }

            //The same result can be achieved by using logical and
            if (isRegistered && userName != "" && isAdmin)
            {
                Console.WriteLine("User is registered");
                Console.WriteLine("Hello {0}", userName);
                Console.WriteLine("Oh, an Admin logged in. Welcome");

                if (userName == "Mike")
                {
                    Console.WriteLine("Welcome, Master Mike");
                }
            }
        }
    }
}