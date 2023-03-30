using System.Collections;

namespace Challenge___HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student(1, "Student 1", 100),
                new Student(2, "Student 2", 101),
                new Student(3, "Student 3", 102),
                new Student(4, "Student 4", 103),
                new Student(5, "Student 5", 104),
                new Student(5, "Student 6", 105),
                new Student(2, "Student 7", 106),
            };

            Hashtable studentsTable = new Hashtable();

            foreach (Student student in students)
            {
                if (!studentsTable.ContainsKey(student.ID))
                    studentsTable.Add(student.ID, student);
                else
                    Console.WriteLine("Sorry, a student with the same ID already exists");
            }
        }
    }
}