using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_classes
{
    public class ClassRoom
    {
        public List<Student> Students { get; set; }
        public Teacher ClassTeacher { get; set; }

        public ClassRoom(Teacher classTeacher)
        {
            Students = new List<Student>();
            ClassTeacher = classTeacher;
        }
    }
}
