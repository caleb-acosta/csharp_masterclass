using System.Xml.Linq;

namespace LinqXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentsXML =
                        @"<Students>
                            <Student>
                                <Name>Toni</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                                <FavoriteFood>Pasta</FavoriteFood>
                            </Student>
                            <Student>
                                <Name>Carla</Name>
                                <Age>17</Age>
                                <University>Yale</University>
                                <FavoriteFood>Pizza</FavoriteFood>
                            </Student>
                            <Student>
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech</University>
                                <FavoriteFood>Tacos</FavoriteFood>
                            </Student>
                            <Student>
                                <Name>Caleb</Name>
                                <Age>24</Age>
                                <University>Beijing Tech</University>
                                <FavoriteFood>Sushi</FavoriteFood>
                            </Student>
                        </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               FavoriteFood = student.Element("FavoriteFood").Value
                           };

            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} and his/her favorite food is {3}", student.Name, student.Age, student.University, student.FavoriteFood);
            }

            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} from University {2}", student.Name, student.Age, student.University);
            }
        }
    }
}