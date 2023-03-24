using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Database
    {

        /*
            Sadece database ile ilgili işlemler bu classta olmalı.
         */

        public void OpenConnect()
        {
            Console.WriteLine("Connection open");
        }

        public void CloseConnect()
        {
            Console.WriteLine("Connection closed.");
        }
        public string GetSqlCommand()
        {
            string sqlCommand = "select * from";
            return sqlCommand;
        }

    }
}
