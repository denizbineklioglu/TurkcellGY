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
    public class UserFunctions
    {

        IClassroomService _classroomService;
        ITeacherService _teacherService;
        IStudentService _studentService;
        
        public UserFunctions(IClassroomService classroomService, ITeacherService teacherService, IStudentService studentService)
        {
            _classroomService = classroomService;
            _teacherService = teacherService;
            _studentService = studentService;
        }

        public void AddStudentWithUser(List<Student> students)
        {
            int i = 1;
            while (true)
            {                
                Console.WriteLine("Öğrenci eklemek için 1, öğrenci eklemeyi bitirmek için -1'e basın.");
                int response = int.Parse(Console.ReadLine());
                if (response == 1)
                {
                    Student student = new();
                    student.ID = i;
                    Console.Write("Öğrenci Adı: ");
                    student.FirstName = Console.ReadLine();
                    Console.Write("Öğrenci Soyadı: ");
                    student.LastName = Console.ReadLine();
                    Console.Write("Öğrenci Sınıf adı: ");
                    string studentClass = Console.ReadLine();
                    var classroom = _classroomService.GetByName(studentClass);
                    if (classroom == null)
                    {
                        Console.WriteLine("Sınıf adı bulunamadı");
                    }
                    else
                    {
                        student.StudentGrade = classroom;
                        _classroomService.AddClassroomInStudent(student);
                        _studentService.Add(student);
                        i++;
                    }                    
                }
                else if (response != -1)
                {
                    Console.WriteLine("Yanlış bir tuşa bastınız.");
                }
                else
                {
                    break;
                }
            }
        }

        public void AddTeacherWithUser(List<Teacher> teachers)
        {
            int i = 1;
            while (true)
            {                
                Console.WriteLine("Öğretmen eklemek için 1, Öğretmen eklemeyi bitirmek için -1'e basın.");
                int response = int.Parse(Console.ReadLine());
                if (response == 1)
                {
                    Teacher teacher = new();
                    teacher.ID = i;
                    Console.Write("Öğretmen Adı: ");
                    teacher.FirstName = Console.ReadLine();
                    Console.Write("Öğretmen Soyadı: ");
                    teacher.LastName = Console.ReadLine();
                    Console.Write("Öğretmen sınıf adı : ");
                    string teacherClass = Console.ReadLine();
                    var classroom = _classroomService.GetByName(teacherClass);
                    if (classroom == null)
                    {
                        Console.WriteLine("Sınıf bulunamadı");
                    }
                    else
                    {
                        teacher.TeacherGrade = classroom;
                        _classroomService.AddClasrroomInTeacher(teacher);
                        _teacherService.Add(teacher);
                        i++;
                    }
                }
                else if (response != -1)
                {
                    Console.WriteLine("Yanlış bir tuşa bastınız.");
                }
                else
                {
                    break;
                }
            }
        }

        public void AddClassWithUser(List<Classroom> classrooms)
        {
            int i = 1;
            while (true)
            {                
                Console.WriteLine("Sınıf eklemek için 1, Sınıf eklemeyi bitirmek için -1'e tıklayın");
                int response = int.Parse(Console.ReadLine());
                if (response == 1)
                {
                    Classroom classroom = new();
                    classroom.ID = i;
                    Console.Write("Sınıf adı: ");
                    classroom.Name = Console.ReadLine();
                    classroom.Students = new();
                    _classroomService.Add(classroom);
                    i++;
                }
                else if (response != -1)
                {
                    Console.WriteLine("Yanlış bir tuşa bastınız.");
                }
                else
                {
                    break;
                }

            }                     
        }

    }
}
