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



Console.Write("Kaç sınıf ekleyeceksiniz :");
int classCount = int.Parse(Console.ReadLine());
for (int i = 1; i <= classCount; i++)
{
    Console.Write($"{i}.Sınıf");
    classroomManager.Add(Functions.AddClassWithUser(classrooms));
}

Console.Write("Kaç öğrenci ekleyeceksiniz: ");
int studentCount = int.Parse(Console.ReadLine());
for (int i = 1; i <= studentCount; i++)
{
    Console.Write($"{i}.öğrenci");
    studentManager.Add(Functions.AddStudentWithUser(students));
}

Console.Write("Kaç öğretmen ekleyeceksiniz: ");
int teacherCount = int.Parse(Console.ReadLine());
for (int i = 1; i <= teacherCount; i++)
{
    Console.Write($"{i}.öğretmen");
    teacherManager.Add(Functions.AddTeacherWithUser(teachers));
}


/*
    Öğrenci ile ilgili  ==== >  Öğrenci adı , öğrenci hangi sınıfta , kaç tane öğrenci var sorgulama
    Öğretmen ile ilgili ==== >  Öğretmen adı, öğretmen hangi sınıftan sorumlu , kaç tane öğretmen var sorgulama
    Sınıf ile ilgili    ==== >  Sınıf adı sorgulama, hangi sınıfta kaç öğrenci var
*/






