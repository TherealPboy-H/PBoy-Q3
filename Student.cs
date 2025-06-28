using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBoy_Q3
{
    internal class Student
    {
        public string ID { get; }
        public string Name { get; }
        public int Grade { get; }

        public Student(string id, string name, int grade)
        {
            ID = id;
            Name = name;
            Grade = grade;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Grade: {Grade}");
        }
    }
}
