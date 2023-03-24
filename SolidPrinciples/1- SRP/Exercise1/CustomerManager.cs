using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer added");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Customer deleted");

            // Bu şekilde yapılabilir.
            Log.Logger();
        }

        /*
            Loglama işleminin burada bir metot olarak yazılması yanlıştır. 
            Bir çok yerde kullanılabilir,customer'ın yapacağı bir iş değildir.
            Bu yüzden Log class'ı açılır.
         */

        //public void Log()
        //{
        //    Console.WriteLine("Logged.");
        //}
    }
}
