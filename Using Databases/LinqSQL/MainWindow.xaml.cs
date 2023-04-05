using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinqSQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataClasses1;
        public MainWindow()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LinqSQL.Properties.Settings.csharp_masterclassConnectionString"].ConnectionString;
            InitializeComponent();
            dataClasses1 = new DataClasses1DataContext(connectionString);

            InsertUniversities();
            InsertStudents();
            InsertLectures();
            InsertStudentLectureAssociations();
            GetUniversityOf("Toni");
            GetLecturesOf("Toni");
            GetAllStudentsFrom("Yale");
            UpdateStudentName("Toni", "Antonio");
            DeleteStudent("Carla");
        }
        public void InsertUniversities()
        {
            dataClasses1.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";
            dataClasses1.University.InsertOnSubmit(yale);

            University beijingTech = new University();
            beijingTech.Name = "Beijing Tech";
            dataClasses1.University.InsertOnSubmit(beijingTech);

            dataClasses1.SubmitChanges();

            MainDataGrid.ItemsSource = dataClasses1.University;
        }

        public void InsertStudents()
        {
            dataClasses1.ExecuteCommand("delete from Student");
            University yale = dataClasses1.University.First(un => un.Name.Equals("Yale"));
            University beijingTech = dataClasses1.University.First(un => un.Name.Equals("Beijing Tech"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "female", UniversityID = yale.Id });
            students.Add(new Student { Name = "Toni", Gender = "male", University = yale });
            students.Add(new Student { Name = "Leyle", Gender = "female", University = beijingTech });
            students.Add(new Student { Name = "Jame", Gender = "trans-gender", University = beijingTech });

            dataClasses1.Student.InsertAllOnSubmit(students);
            dataClasses1.SubmitChanges();

            MainDataGrid.ItemsSource = dataClasses1.Student;
        }

        public void InsertLectures()
        {
            dataClasses1.ExecuteCommand("delete from Lecture");
            dataClasses1.Lecture.InsertOnSubmit(new Lecture { Name = "Math" });
            dataClasses1.Lecture.InsertOnSubmit(new Lecture { Name = "History" });

            dataClasses1.SubmitChanges();

            MainDataGrid.ItemsSource = dataClasses1.Lecture;
        }

        public void InsertStudentLectureAssociations()
        {
            dataClasses1.ExecuteCommand("delete from StudentLecture");

            Student Carla = dataClasses1.Student.First(st => st.Name.Equals("Carla"));
            Student Toni = dataClasses1.Student.First(st => st.Name.Equals("Toni"));
            Student Leyle = dataClasses1.Student.First(st => st.Name.Equals("Leyle"));
            Student Jame = dataClasses1.Student.First(st => st.Name.Equals("Jame"));

            Lecture Math = dataClasses1.Lecture.First(lc => lc.Name.Equals("Math"));
            Lecture History = dataClasses1.Lecture.First(lc => lc.Name.Equals("History"));

            dataClasses1.StudentLecture.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataClasses1.StudentLecture.InsertOnSubmit(new StudentLecture { Student = Toni, Lecture = Math });

            StudentLecture slToni = new StudentLecture();
            slToni.StudentId = Toni.Id;
            slToni.LectureId = History.Id;
            dataClasses1.StudentLecture.InsertOnSubmit(slToni);

            dataClasses1.StudentLecture.InsertOnSubmit(new StudentLecture { Student = Leyle, Lecture = History });

            dataClasses1.SubmitChanges();

            MainDataGrid.ItemsSource = dataClasses1.StudentLecture;
        }

        public void GetUniversityOf(string student)
        {
            Student resultStudent = dataClasses1.Student.First(st => st.Name.Equals(student));

            University university = resultStudent.University;

            List<University> universities = new List<University>();
            universities.Add(university);

            MainDataGrid.ItemsSource = universities;

        }

        public void GetLecturesOf(string student)
        {
            Student resultStudent = dataClasses1.Student.First(st => st.Name.Equals(student));

            var lectures = from sl in resultStudent.StudentLecture select sl.Lecture;

            MainDataGrid.ItemsSource = lectures;
        }

        public void GetAllStudentsFrom(string university)
        { 
            var students = from student in dataClasses1.Student where student.University.Name.Equals(university) select student;
            MainDataGrid.ItemsSource = students;
        }

        public void GetAllUniversitiesWithGender(string gender)
        {
            var transgernderUniversities = from student in dataClasses1.Student
                                           join university in dataClasses1.University
                                           on student.University equals university
                                           where student.Gender.Equals(gender)
                                           select university;

            MainDataGrid.ItemsSource = transgernderUniversities;
        }

        public void GetAllLecturesFrom(string univeristy)
        {
            var lecturesFromBeijingTech = from sl in dataClasses1.StudentLecture
                                          join student in dataClasses1.Student on sl.StudentId equals student.Id
                                          where student.University.Name.Equals(univeristy)
                                          select sl.Lecture;

            MainDataGrid.ItemsSource = lecturesFromBeijingTech;
        }

        public void UpdateStudentName(string student, string name)
        {
            Student resultStudent = dataClasses1.Student.FirstOrDefault(st => st.Name.Equals(student));

            resultStudent.Name = name;

            dataClasses1.SubmitChanges();

            MainDataGrid.ItemsSource = dataClasses1.Student;
        }

        public void DeleteStudent(string student)
        {
            Student resultStudent = dataClasses1.Student.FirstOrDefault(st => st.Name.Equals(student));
            
            dataClasses1.Student.DeleteOnSubmit(resultStudent);

            dataClasses1.SubmitChanges();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqSQL.Properties.Settings.csharp_masterclassConnectionString"].ConnectionString;
            dataClasses1 = new DataClasses1DataContext(connectionString);

            MainDataGrid.ItemsSource = dataClasses1.Student;
        }

    }
}
