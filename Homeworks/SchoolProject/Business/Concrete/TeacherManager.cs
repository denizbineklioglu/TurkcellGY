using SchoolProject.Business.Abstract;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SchoolProject.Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private readonly List<Teacher> _teacherList;
        public TeacherManager(List<Teacher> teachers)
        {
            _teacherList = teachers;
        }
        public void Add(Teacher entity)
        => _teacherList.Add(entity);        

        public void Delete(int id)    
        {
            var teacher = _teacherList.Single(t => t.ID == id);
            if (teacher != null)
            {
                _teacherList.Remove(teacher);
            }
            else
            {
                Console.WriteLine("Öğretmen Bulunamadı");
            }
        }

        public void GetAll()
        {
            _teacherList.ToList().ForEach(c => Console.WriteLine($"{c.FirstName} {c.LastName}"));
        }

        public Teacher GetById(int id)
        {
            var result = _teacherList.Single(t => t.ID == id);
            return result;
        }

        public bool IsTeacherThere(string firstName, string lastName)
        {
            var result = _teacherList.Where(t => t.FirstName == firstName && t.LastName == lastName);
            if (result.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TeacherClass(string name, string lastName)
        {
            var result = _teacherList.SingleOrDefault(s => s.FirstName == name && s.LastName == lastName);
            if (result != null)
            {
                Console.WriteLine($"{result.FirstName} {result.LastName} isimli öğretmen  {result.TeacherGrade.Name} sınıfından sorumlu.");
            }
            else
            {
                Console.WriteLine("Öğretmen Bulunamadı.");
            }
        }

        public void Update(Teacher entity)
        {
            var oldTeacher = _teacherList.SingleOrDefault(t => t.ID == entity.ID);
            if (oldTeacher != null)
            {
                oldTeacher.FirstName = entity.FirstName;
                oldTeacher.LastName = entity.LastName;
                oldTeacher.TeacherGrade = entity.TeacherGrade;
            }
            else
            {
                Console.WriteLine("Öğretmen Bulunamadı.");
            }
        }
    }
}
