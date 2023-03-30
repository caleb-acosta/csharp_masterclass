using System.Reflection.Metadata;

namespace Challenge___If_statements
{
    internal class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
        }

        static void Register()
        {
            Console.WriteLine("Register\nEnter your Username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter your Password:");
            password = Console.ReadLine();
            Console.WriteLine("Succesfully registered");
        }
        static void Login() 
        {
            Console.WriteLine("Login\nEnter your Username:");
            string try_username = Console.ReadLine();
            Console.WriteLine("Enter your Password:");
            string try_password = Console.ReadLine();

            if (try_username.Equals(username))
            {
                if (try_password.Equals(password))
                {
                    Console.WriteLine("Succesfully Loged in");
                }
                else {
                    Console.WriteLine("Incorrect Password");
                }
            }
            else 
            {
                Console.WriteLine("Incorrect username");
            }
        }
    }
}