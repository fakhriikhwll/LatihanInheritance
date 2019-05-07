using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Teacher : Person
    {
        public string TeacherId { get; set; }
        public string Subject { get; set; }

        // constructor
        public Teacher(string name, int age, string id, string subject) : base(name, age)
        {
            Name = name;
            Age = age;
            TeacherId = id;
            Subject = subject;
        }
    }
}
