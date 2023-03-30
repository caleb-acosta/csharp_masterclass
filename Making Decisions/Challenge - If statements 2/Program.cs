namespace Challenge___If_statements_2
{
    internal class Program
    {
        static int highscore = 2000;
        static string highscoreUsername = "Caleb";

        static void Main(string[] args)
        {
            Highscore(1999, "Agus");
            Highscore(2001, "Joca-Cola");
        }

        static void Highscore(int score, string username) {
            if (score > highscore)
            {
                highscore = score;
                highscoreUsername = username;

                Console.WriteLine("New highscrore is " + score);
                Console.WriteLine("Its now held by: " + username);
            }
            else {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by" + highscoreUsername);
            }
        }
    }
}