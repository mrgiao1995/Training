using ConsoleAppStudentManagement.Model;
using System;

namespace ConsoleAppStudentManagement.Module
{
    public class StudentModule
    {
        public static void InputStudentInfomation(StudentModel student)
        {
            Console.WriteLine("Please input student name");
            student.FullName = Console.ReadLine();
            Console.WriteLine("Please input student date of birth");
            student.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please input student address");
            student.Address = Console.ReadLine();
        }
    }
}
