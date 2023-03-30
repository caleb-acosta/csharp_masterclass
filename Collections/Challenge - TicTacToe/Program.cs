namespace Challenge___TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                new Board().Play();
                Console.WriteLine("Press any key to play again...");
                Console.Read();
            } while (true);
        }
    }
}