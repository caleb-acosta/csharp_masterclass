using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge___HashTables
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int GPA { get; set; }

        public Student(int iD, string name, int gPA)
        {
            ID = iD;
            Name = name;
            GPA = gPA;
        }
    }
}
