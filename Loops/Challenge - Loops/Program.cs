namespace Challenge___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalStudents = 0;
            int AccGrades = 0;

            do
            {
                Console.WriteLine("Enter grade:");
                int grade;
                if (int.TryParse(Console.ReadLine(), out grade))
                {
                    if (grade >= 0 && grade <= 20)
                    {
                        AccGrades += grade;
                        totalStudents++;
                        Console.WriteLine("Current average grade:" + AccGrades / totalStudents);
                        continue;
                    }
                    if (grade == -1)
                        break;
                }
                Console.WriteLine("Wrong input");
            } while (true);
            Console.WriteLine("Average grade:" + AccGrades/totalStudents);
        }
    }
}