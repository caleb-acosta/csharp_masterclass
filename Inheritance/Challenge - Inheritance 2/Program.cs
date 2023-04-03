namespace Challenge___Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Caleb Acosta", "Caleb", 100000);
            Boss boss = new Boss("Vito Corleone", "Vito", 10000000, "Cadillac Fleetwood");
            Trainee trainee = new Trainee("Luke Skywalker", "Luke", 100, 4, 4);

            Console.WriteLine("Employee:");
            employee.Work();

            Console.WriteLine("Boss:");
            boss.Lead();

            Console.WriteLine("Trainee:");
            trainee.Learn();
        }
    }

    internal class Employee {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public Employee() {
            Name = "Caleb Acosta";
            FirstName = "Caleb;";
            Salary = 100000;
        }
        public virtual void Work() {
            Console.WriteLine("Working...");
        }

        public void Pause() {
            Console.WriteLine("Having a break..");
        }

    }

    internal class Boss:Employee {
        public string CompanyCar { get; set; }

        public Boss(string name, string firstName, int salary, string companyCar)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
            CompanyCar = companyCar;
        }

        public void Lead() {
            Console.WriteLine("Leading..");
        }
    }

    internal class Trainee : Employee {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(string name, string firstName, int salary, int workingHours, int schoolHours)
        {
            Name = name;
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
            Salary = salary;
            FirstName = firstName;
        }

        public void Learn() {
            Console.WriteLine("Learning {0} hours...", SchoolHours);
        }

        public override void Work()
        {
            Console.WriteLine("Working {0} hours...", WorkingHours);
        }
    }
}