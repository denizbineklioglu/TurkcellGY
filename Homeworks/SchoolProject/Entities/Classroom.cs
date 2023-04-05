using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Entities
{
    public class Classroom:Entity
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public Teacher? Teacher { get; set; }        
    }
}
