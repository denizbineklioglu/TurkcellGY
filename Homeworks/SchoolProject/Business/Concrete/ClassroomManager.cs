using SchoolProject.Business.Abstract;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public int Count() => _classes.Count();

        public int CountClassStudents(int? classID, string? className)
        {
            if (classID != null)
            {
                var result = _classes.Where(c => c.ID == classID).Count();
                return result;
            }
            else
            {
                var result = _classes.Where(c => c.Name == className).Count();
                return result;
            }
        }

        public void Delete(int id) 
        {
            var classroom = _classes.Single(t => t.ID == id);
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

        public bool IsClassThere(int? classID = null, string? className = null)
        {
            if (classID != null)
            {
                var result = _classes.Where(c => c.ID == classID);
                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                var result = _classes.Where(c => c.Name == className);
                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
    }
}
