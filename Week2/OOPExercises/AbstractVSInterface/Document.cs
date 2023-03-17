using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises.AbstractVSInterface
{

    /*
        Abstract metotlar miras alındığı sınıfta ezilmek zorundadır.
        Bu örnekte, eğer ki print özelliği sadece PDF için kaldırılmak
        istenseydi, işin içerisine artık INTERFACE kavramı girerdi. 
        Çünkü base class'tan Print metodunu kaldırırsak EXCEL class'ıda print
        işlemi yapamayacak.
     */

    public abstract class Document
    {
        public abstract void Save();
        public abstract void Open();

        public void Copy(string from, string to)
        {
            Console.WriteLine($"Copied {from} {to}");
        }

        public string Title { get; set; }
        public string Owner { get; set; }

    }

    public class PDFDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Open PDF.");
        }

        public override void Save()
        {
            Console.WriteLine("Save PDF.");
        }
    }

    public class ExcelDocument : Document,MakePrint
    {
        public override void Open()
        {
            Console.WriteLine("Open Excel.");
        }

        public void Print()
        {
            Console.WriteLine("Print Excel.");
        }

        public override void Save()
        {
            Console.WriteLine("Save Excel.");
        }
    }

    public interface MakePrint
    {
        public void Print();
    }

}
