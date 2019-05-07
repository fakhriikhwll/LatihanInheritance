using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Student : Person
    {
        public string StudentId { get; set; }
        public string Email { get; set; }

        // constructor
        public Student(string name, int age, string id, string email) : base(name, age)
        {

            Name = name;
            Age = age;
            StudentId = id;
            Email = email;
        }
    }
}