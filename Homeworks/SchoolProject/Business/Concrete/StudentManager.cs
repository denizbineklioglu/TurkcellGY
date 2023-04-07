using SchoolProject.Business.Abstract;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly List<Student> _students;
        public StudentManager(List<Student> students)
        {
            _students = students;
        }

        public void Add(Student entity) => _students.Add(entity);
        

        public void Delete(int id)
        {
            var student = _students.Single(t => t.ID == id);
            if (student != null)
            {
                _students.Remove(student);
            }
            else
            {
                Console.WriteLine("Öğretmen Silinemedi.");
            }
        }

        public void GetAll()
        {
            _students.ToList().ForEach(c => Console.WriteLine($"{c.FirstName} {c.LastName}"));
        }

        public Student GetById(int id)
        {
            var result = _students.Single(s => s.ID == id);
            return result;
        }

        public bool IsStudentInClass(string firstName, string lastName)
        {
            var student = _students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            if (student != null)
                return true;
            else
                return false;
        }

        public void StudentClass(string firstName, string lastName)
        {
            var student = _students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            if (student != null)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} adlı öğrencinin sınıfı {student.StudentGrade.Name}");
            }
            else
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }
        }

        public void Update(Student entity)
        {
            var oldStudent = _students.Single(t => t.ID == entity.ID);
            if (oldStudent != null)
            {
                _students.Remove(oldStudent);
                _students.Add(entity);
            }
            else
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }
        }
    }
}
