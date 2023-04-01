using SchoolProject.Business.Concrete;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business
{
    public static class Functions
    {       
        public static Student AddStudentWithUser(List<Student> students)
        {
            Student student = new();
            Console.Write("Öğrenci ID: ");
            int studentID = int.Parse(Console.ReadLine());
            Console.Write("Öğrenci Adı: ");
            student.FirstName = Console.ReadLine();
            Console.Write("Öğrenci Soyadı: ");
            student.LastName = Console.ReadLine();
            Console.Write("Öğrenci Sınıfı: ");
            student.StudentGrade = Console.ReadLine();

            return student;
        }

        public static Teacher AddTeacherWithUser(List<Teacher> teachers)
        {
            Teacher teacher = new();
            Console.Write("Öğretmen ID: ");
            teacher.ID = int.Parse(Console.ReadLine());
            Console.Write("Öğretmen Adı: ");
            teacher.FirstName = Console.ReadLine();
            Console.Write("Öğretmen sınıf adı: ");
            teacher.TeacherGrade = Console.ReadLine();
            return teacher;
        }

        public static Classroom AddClassWithUser(List<Classroom> classrooms)
        {
            Classroom classroom = new();
            Console.Write("Sınıf ID: ");
            classroom.ID = int.Parse(Console.ReadLine());
            Console.Write("Sınıf adı: ");
            classroom.Name = Console.ReadLine();           

            return classroom;
        }

    }
}
