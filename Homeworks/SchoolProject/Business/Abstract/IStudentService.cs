using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Abstract
{
    public interface IStudentService : IGenericService<Student>
    {
        void SendHomework();
        bool IsStudentInClass(string firstName, string lastName);
        void GetStudentsInClass(string className);
    }
}
