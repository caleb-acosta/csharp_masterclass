namespace FirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human denis = new Human("Caleb", "Acosta", 24, "brown");
            denis.IntroduceMyself();

            Human amalia = new Human("Walter", "White", "brown");
            amalia.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Agent K");
            natalie.IntroduceMyself();

            Human michael = new Human("Michael", "Myers");
            michael.IntroduceMyself();

            Human frank = new Human("Marty", "McFly", 25);
            frank.IntroduceMyself();

        }
    }
}