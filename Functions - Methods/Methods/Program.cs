namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Jokis";
            string friend2 = "Daniel";
            string friend3 = "Roman";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
        }

        public static void GreetFriend(string name) {
            Console.WriteLine("Hi {0}, my friend!", name);
        }
    }
}