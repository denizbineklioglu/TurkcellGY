using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    /*
        Bu senaryoda, diyelim ki şirketimiz bizden verilerin
        text dosyasına kaydedilmesini istedi. Biz de ona göre direkt her işlemi
        File class'ında yaptık. Ama zaman geçti ve şirket artık bazı verilerin 
        excel doyasına kaydedilmesini istedi. Bu seferde hadi gidip başka bir ifle
        yönetmeye çalışırsak, yeni özellik getirmeye çalışırken mevcut kodumuzu değiştirmiş
        oluruz. Belki ileride şirket 2 farklı tip dosya kaydı daha isteyecek ya da 
        excel'in kaldırılmasını isteyecek. Bu çok büyük bir kod yükü olur. Bunun önüne geçmek için
        IFile adında bir interface oluşturduk ve her file'ın ortak özelliği olan save metodunun
        imzasını yazdık. Bundan sonra hangi dosyaya kaydetme istenirse, yapılacak tek şey
        bu interface'i implement etmek. Yani mevcut kodları ellememek ve yeni özellikler getirmek.
     */

    //public class File
    //{
    //    public void Save(string typeFile)
    //    {
    //        if (typeFile =="txt")
    //        {
    //            //
    //        }
    //        if (typeFile == "exl")
    //        {
    //            //
    //        }
    //    }
    //}


    public interface IFile
    {
        public void SaveToFile();

    }

    public class TxtFile : IFile
    {
        public void SaveToFile()
        {
            Console.WriteLine("Text dosyasına kaydedildi.");
        }
    }

    public class ExcelFile : IFile
    {
        public void SaveToFile()
        {
            Console.WriteLine("Excel dosyasına kaydedildi.");
        }
    }

}
