using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Abstract
{
    public interface ITeacherService: IGenericService<Teacher>
    {
        void TeacherClass(List<Teacher> teachers, int id);
        bool IsTeacherThere(string firstName , string lastName);
    }
}
