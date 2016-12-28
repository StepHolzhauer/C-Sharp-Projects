using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_classes
{
    public class Student : IPerson
    {
        public List<int> Grades { get; set; }
        public int Age { get; set; }

        public Student(int age)
        {
            Grades = new List<int>();
            Age = age;
        }
    }
}
