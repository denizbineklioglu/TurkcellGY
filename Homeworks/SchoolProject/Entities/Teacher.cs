using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Entities
{
    public class Teacher:Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Classroom TeacherGrade { get; set; }
    }
}
