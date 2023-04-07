using SchoolProject.Business.Abstract;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Concrete
{
    public class HomeworkManager : IHomeworkService
    {
        public void SendHomework(Student student)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} adlı öğrencinin ödevi gönderildi.");
        }
    }
}
