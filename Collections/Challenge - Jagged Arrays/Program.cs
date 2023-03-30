namespace Challenge___Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] friends = new string[][]
            {
                new string[]{"Gandalf", "Saruman"},
                new string[]{"Frodo", "Sam"},
                new string[]{"Smeagol", "Gollum"},
            };

            Console.WriteLine("Hi {0}, I would like you to know {1}", friends[0][0], friends[1][1]);
            Console.WriteLine("Hi {0}, I would like you to know {1}", friends[1][0], friends[2][1]);
            Console.WriteLine("Hi {0}, I would like you to know {1}", friends[2][0], friends[0][1]);

        }
    }
}