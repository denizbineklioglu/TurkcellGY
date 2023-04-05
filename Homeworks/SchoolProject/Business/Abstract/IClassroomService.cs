using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Abstract
{
    public interface IClassroomService : IGenericService<Classroom>
    {
        bool IsClassThere(int? classID, string? className);
        int CountClassStudents(int? classID, string? className);
        void AddClasrroomInTeacher(Teacher teacher);
        void AddClassroomInStudent(Student student);
    }
}
