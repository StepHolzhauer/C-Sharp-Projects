using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_classes
{
    class Program
    {


        static void Main(string[] args)
        {
            School TheSchool = new School();
            ClassRoom Class1 = new ClassRoom(new Teacher(2000,31));
            ClassRoom Class2 = new ClassRoom(new Teacher(1353, 25));
            ClassRoom Class3 = new ClassRoom(new Teacher(1864, 32));
            ClassRoom Class4 = new ClassRoom(new Teacher(1530, 28));


            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int RngNumber = random.Next(12, 29);
                Class1.Students.Add(new Student(RngNumber));
            }
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int RngNumber = random.Next(12, 29);
                Class2.Students.Add(new Student(RngNumber));
            }
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int RngNumber = random.Next(12, 29);
                Class3.Students.Add(new Student(RngNumber));
            }
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int RngNumber = random.Next(12, 29);
                Class4.Students.Add(new Student(RngNumber));
            }


            TheSchool.Classes.Add(Class1);
            TheSchool.Classes.Add(Class2);
            TheSchool.Classes.Add(Class3);
            TheSchool.Classes.Add(Class4);

        }
    }
}
