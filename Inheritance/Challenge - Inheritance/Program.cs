namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("Happy birthday!", true, "Caleb Acosta");
            Console.WriteLine(post.ToString());

            ImagePost imagePost = new ImagePost("Hello!", "Caleb Acosta",
                "https://images.com/hello", true);

            VideoPost videoPost = new VideoPost("Memories", "Caleb Acosta",
                "https://video.com/memories", true, 10);

            Console.WriteLine(videoPost.ToString());

            videoPost.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost.Stop();
        }
    }
}