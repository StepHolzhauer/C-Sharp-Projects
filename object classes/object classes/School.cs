using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_classes
{
    public class School
    {
        public List<ClassRoom> Classes { get; set; }
        public List<IPerson> Everyone { get; set; }

        public School()
        {
            Classes = new List<ClassRoom>();
            Everyone = new List<IPerson>();
        }
    }
}
