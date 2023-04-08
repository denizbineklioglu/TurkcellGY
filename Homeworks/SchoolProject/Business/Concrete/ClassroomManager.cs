using SchoolProject.Business.Abstract;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Concrete
{
    public class ClassroomManager : IClassroomService
    {
        private readonly List<Classroom> _classes;

        public ClassroomManager(List<Classroom> classrooms)
        {
            _classes = classrooms;
        }

        public void Add(Classroom entity) => _classes.Add(entity);        

        public void Delete(int id) 
        {
            var classroom = _classes.SingleOrDefault(t => t.ID == id);
            if (classroom != null)
            {
                _classes.Remove(classroom);
            }
            else
            {
                Console.WriteLine("Öğretmen Bulunamadı");
            }
        }

        public void GetAll()
        {
            _classes.ToList().ForEach(c => Console.WriteLine($"{c.Name}"));
        }

        public bool IsClassThere(string className)
        {
            var result = _classes.SingleOrDefault(c => c.Name == className);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(Classroom entity)
        {
            var oldClass = _classes.Single(c => c.ID == entity.ID);
            if (oldClass != null)
            {
                _classes.Remove(oldClass);
                _classes.Add(entity);
            }
            else
            {
                Console.WriteLine("Sınıf bulunamadı.");
            }
        } 
        

        public Classroom GetById(int id)
        {
            var result = _classes.SingleOrDefault(c => c.ID == id);
            return result;
        }

        public void AddClasrroomInTeacher(Teacher teacher)
        {
            var teacherClass = teacher.TeacherGrade;
            teacherClass.Teacher = teacher;
        }

        public void AddClassroomInStudent(Student student)
        {
            var studentClass = student.StudentGrade;
            studentClass.Students.Add(student);
        }

        public void FindClassStudents(string className)
        {
            var result = _classes.FirstOrDefault(c => c.Name == className);
            if (result != null)
            {
                result.Students.ToList().ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
            }
            else
            {
                Console.WriteLine("Sınıf bulunamadı.");
            }
        }

        public void ClassTeacher(string className)
        {
            var result = _classes.SingleOrDefault(c => c.Name == className);
            if(result != null)
            {
                Console.WriteLine($"{className} adlı sınıfın rehber öğretmeni {result.Teacher.FirstName} {result.Teacher.LastName} ");
            }
            else
            {
                Console.WriteLine("Sınıf Bulunamadı.");
            }
        }

        public Classroom GetByName(string className)
        {
            
            var result = _classes.SingleOrDefault(c => c.Name == className);
            if (result != null)
            {
                return result;
            }
                          
            return null;
                        
        }
    }
}
