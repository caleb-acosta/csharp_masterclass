namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring a variable
            int num1;
            // Assigning a value to a variable
            num1 = 13;
            
            // Declaring an initialazing a variable in one go
            int num2 = 23;
            num2 = 100;

            //Using concatenation 
            Console.WriteLine("num1 is " + num1);
            int sum = num1 + num2;

            Console.WriteLine("num1: " + num1 + "num2" +  num2 + " is " + sum);

            double d1 = 3.1416;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            double f1 = 3.1416f;
            double f2 = 5.1f;
            double fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            Console.Read();
        }
    }
}