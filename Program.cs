using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person ("IRON", 23);
            person.GetNameAndAge();

            Teacher teacher = new Teacher ("Thanos", 99, "112265", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Tony", 19, "11111", "Tony1234@amikom.ac.id");
            student.GetNameAndAge();

            /*Person person = new Person();
            person.Name = "IRON";
            person.Age = 23;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Thanos";
            teacher.Age = 99;
            teacher.TeacherId = "112265";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Student student = new Student();
            student.Name = "Tony";
            student.Age = 19;
            student.StudentId = "11111";
            student.Email = "Tony1234@amikom.ac.id";
            student.GetNameAndAge();*/

            Console.ReadKey();
        }
    }
}
