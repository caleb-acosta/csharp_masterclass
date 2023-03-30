namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5, 4, 3);

            Console.WriteLine("Volume is {0}", box.Volume);
            Console.WriteLine("Front Surface is {0}", box.FrontSurface);

        }
    }
}