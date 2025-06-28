using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PBoy_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List();
            int choice;

            do
            {
                ShowMenu();
                choice = GetMenuChoice();
                HandleChoice(choice, students);
            }
            while (choice != 5);
        }

        static void ShowMenu()
        {
            WriteLine("\nMenu:");
            WriteLine("1. Add Student");
            WriteLine("2. Delete Student");
            WriteLine("3. Display All Students");
            WriteLine("4. Search Student by ID");
            WriteLine("5. Exit");
            Write("Enter your choice: ");
        }

        static int GetMenuChoice()
        {    int choice;
            while (!int.TryParse(ReadLine(), out  choice))
            {
                Write("Invalid input. Enter a number: ");
            }
            return choice;
        }

        static void HandleChoice(int choice, List students)
        {
            WriteLine();
            switch (choice)
            {
                case 1:
                    AddStudent(students);
                    break;
                case 2:
                    DeleteStudent(students);
                    break;
                case 3:
                    students.DispalyAll();  // Assuming this method prints all students
                    break;
                case 4:
                    SearchStudentByID(students);
                    break;
                case 5:
                    WriteLine("Exiting the program.");
                    break;
                default:
                    WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void AddStudent(List students)
        {
            Write("Enter Student ID: ");
            string id = ReadLine();
            Write("Enter Name: ");
            string name = ReadLine();
            Write("Enter Grade: ");
            int grade = int.Parse(ReadLine());

            students.AddStudent(new Student(id, name, grade));
            WriteLine("Student added successfully.");
        }

        static void DeleteStudent(List students)
        {
            Write("Enter the position of the student to delete: ");
            int position = int.Parse(ReadLine());
            students.Delete(position);
            WriteLine("Student deleted successfully.");
        }

        static void SearchStudentByID(List students)
        {
            Write("Enter Student ID to search: ");
            string id = ReadLine();
            int index = students.LinearSearch(id);

            if (index != -1)
            {
                WriteLine($"Student found at position {index + 1}:");
                students.GetStudentAt(index).Display();
            }
            else
            {
                WriteLine("Student not found.");
            }


        }
    }
}
