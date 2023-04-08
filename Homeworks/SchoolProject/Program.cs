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
UserFunctions userFunctions = new UserFunctions(classroomManager,teacherManager,studentManager);


userFunctions.AddClassWithUser(classrooms);
userFunctions.AddStudentWithUser(students);
userFunctions.AddTeacherWithUser(teachers);


// Sadece sorgulama işlemlerini konsolda gösterdim. Arka planda silme,güncelleme işlemlemleri de mevcut.

while (true)
{
    Console.WriteLine("1- Sınıf İşlemleri\n2- Öğrenci işlemleri\n3- Öğretmen işlemleri\nÇıkmak için -1'e basın.");
    int response = int.Parse(Console.ReadLine());
    switch (response)
    {
        case 1:
            Console.WriteLine("--------- SINIF İŞLEMLERİ ---------");
            while (true)
            {
                Console.WriteLine("1- Sınıf adı sorgula\n2- Öğretmenini öğrenmek istediğiniz sınıfı sorgula\n3- Sınıftaki öğrencileri listele\nÇıkmak için -1.");
                int classResponse = int.Parse(Console.ReadLine());
                switch (classResponse)
                {
                    case 1:
                        Console.Write("Sorgulanacak sınıf adı: ");
                        string className = Console.ReadLine();
                        if (classroomManager.IsClassThere(className))
                        {
                            Console.WriteLine($"{className} adlı sınıf kayıtlarda bulunmaktadır.");                            
                        }
                        else
                        {
                            Console.WriteLine("Sınıf bulunamadı.");
                        }
                        break;
                    case 2:
                        Console.Write("Sorgulanacak sınıf adı: ");
                        string className2 = Console.ReadLine();
                        classroomManager.ClassTeacher(className2);
                        break;
                    case 3:
                        Console.Write("Öğrencisi listelenecek sınıf adı :");
                        string className3 = Console.ReadLine();
                        classroomManager.FindClassStudents(className3);
                        break;
                    case -1:
                        break;
                    default:
                        break;
                }
                if (classResponse == -1)
                {
                    break;
                }
            }            
            break;
        case 2:
            Console.WriteLine("--------- ÖĞRENCİ İŞLEMLERİ ---------");
            while (true)
            {
                Console.WriteLine("1- Öğrenci sorgula\n2- Öğrencinin hangi sınıfta olduğunu sorgula\nÇıkmak için -1'e basın.");
                int studentResponse = int.Parse(Console.ReadLine());
                switch (studentResponse)
                {
                    case 1:
                        Console.Write("Adı: ");
                        string studentName = Console.ReadLine();
                        Console.Write("Soyadı: ");
                        string studenLastName = Console.ReadLine();
                        if (studentManager.IsStudentInClass(studentName,studenLastName))
                        {
                            Console.WriteLine("Kayıtlarımızda bu öğrenci bulunmaktadır.");
                        }
                        else
                        {
                            Console.WriteLine("Öğrenci bulunamadı");
                        }
                        break;
                    case 2:
                        Console.Write("Adı: ");
                        string studentName1 = Console.ReadLine();
                        Console.Write("Soyadı: ");
                        string studenLastName1 = Console.ReadLine();
                        studentManager.StudentClass(studentName1, studenLastName1);
                        break;
                    default:
                        break;
                }
                if (studentResponse == -1)
                {
                    break;
                }
            }
            break;
        case 3:
            Console.WriteLine("--------- ÖĞRETMEN İŞLEMLERİ ---------");
            while (true)
            {
                Console.WriteLine("1- Öğretmen Sorgula\n2- Öğretmen Sınıfı Sorgula\nÇıkmak için -1. ");
                int teacherResponse = int.Parse(Console.ReadLine());
                switch (teacherResponse)
                {
                    case 1:
                        Console.Write("Adı: ");
                        string teacherName = Console.ReadLine();
                        Console.Write("Soyadı: ");
                        string teacherLastName = Console.ReadLine();
                        if (teacherManager.IsTeacherThere(teacherName,teacherLastName))
                        {
                            Console.WriteLine("Kayıtlarımızda bu öğretmen bulunmaktadır.");
                        }
                        else
                        {
                            Console.WriteLine("Öğretmen Bulunamadı.");
                        }
                        break;
                    case 2:
                        Console.Write("Adı: ");
                        string teacherName1 = Console.ReadLine();
                        Console.Write("Soyadı: ");
                        string teacherLastName1 = Console.ReadLine();
                        teacherManager.TeacherClass(teacherName1, teacherLastName1);
                        break;
                    default:
                        break;  
                }
                if (teacherResponse == -1)
                {
                    break;
                }
            }
            break;
        case -1:
            break;
        default:
            break;
    }
    
}





