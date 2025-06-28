using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBoy_Q3
{
    internal class List
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void Delete(int position)
        {
            if (position < 0 || position >= students.Count)
            {
                Console.WriteLine("Invalid position. No student deleted.");
                return;
            }
            students.RemoveAt(position);
        }

        public void DispalyAll()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students to display.");
                return;
            }

            for (int i = 0; i < students.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                students[i].Display();
            }
        }

        public int LinearSearch(string id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ID == id)
                    return i;
            }
            return -1;
        }

        public Student GetStudentAt(int index)
        {
            if (index >= 0 && index < students.Count)
                return students[index];

            return null;
        }
    }
}
