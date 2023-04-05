using SchoolProject.Business;
using SchoolProject.Business.Concrete;
using SchoolProject.Entities;
using System.Threading.Channels;


List<Student> students = new();
List<Teacher> teachers = new();
List<Classroom> classrooms = new();
StudentManager studentManager = new(students);
TeacherManager  teacherManager = new(teachers); 
ClassroomManager classroomManager = new(classrooms);
Functions functions = new Functions(classroomManager);


int response = 0;

while (response != -1)
{

}


