using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_classes
{
    public class Teacher : IPerson
    {
        public int Salery { get; set; }
        public int Age { get; set; }

        public Teacher(int salery, int age)
        {
            Salery = salery;
            Age = age;
        }
    }
}
