using SchoolProject.Business.Abstract;
using SchoolProject.Business.Concrete;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business
{
    public class Functions
    {

        IClassroomService _classroomService;
        
        public Functions(IClassroomService classroomService)
        {
            _classroomService = classroomService;
        }

        public Student AddStudentWithUser(List<Student> students)
        {
            Student student = new();
            Console.Write("Öğrenci ID: ");
            student.ID = int.Parse(Console.ReadLine());
            Console.Write("Öğrenci Adı: ");
            student.FirstName = Console.ReadLine();
            Console.Write("Öğrenci Soyadı: ");
            student.LastName = Console.ReadLine();
            Console.Write("Öğrenci Sınıf ID'si: ");
            int classID = int.Parse(Console.ReadLine());
            var classroom = _classroomService.GetById(classID);
            student.StudentGrade = classroom;
            _classroomService.AddClassroomInStudent(student);           

            return student;
        }

        public Teacher AddTeacherWithUser(List<Teacher> teachers)
        {
            Teacher teacher = new();
            Console.Write("Öğretmen ID: ");
            teacher.ID = int.Parse(Console.ReadLine());
            Console.Write("Öğretmen Adı: ");
            teacher.FirstName = Console.ReadLine();
            Console.Write("Öğretmen sınıf ID'si: ");
            int classID = int.Parse(Console.ReadLine());
            var classroom = _classroomService.GetById(classID);
            teacher.TeacherGrade = classroom;
            _classroomService.AddClasrroomInTeacher(teacher);

            return teacher;
        }

        public Classroom AddClassWithUser(List<Classroom> classrooms)
        {
            Classroom classroom = new();
            Console.Write("Sınıf ID: ");
            classroom.ID = int.Parse(Console.ReadLine());
            Console.Write("Sınıf adı: ");
            classroom.Name = Console.ReadLine();
            classroom.Students = new();

            return classroom;
        }

    }
}
