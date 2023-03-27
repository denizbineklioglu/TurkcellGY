using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercise
{

    public class CustomerManager
    {
        private readonly IDatabase _database;

        public CustomerManager(IDatabase database)
        {
            this._database = database;
        }

        public void Add(Customer customer)
        {
            _database.Insert(customer);
        }

        public void Delete(int id)
        {
            _database.Delete(id);
        }

        public void Update(Customer customer)
        {
            _database.Update(customer);
        }

    }


    public interface IGenericDal<T>
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }


    public interface IDatabase: IGenericDal<Customer>
    {

    }

    //Sql Server Kullanarak.
    public class SqlCustomerDal : IDatabase
    {
        public void Delete(int id)
        {
            Console.WriteLine("deleted with sql server");
        }

        public void Insert(Customer entity)
        {
            Console.WriteLine("inserted with sql server");
        }

        public void Update(Customer entity)
        {
            Console.WriteLine("updatd with sql server");
        }
    }


    //Oracle Kullanarak.
    public class OracleCustomerDal : IDatabase
    {
        public void Delete(int id)
        {
            Console.WriteLine("deleted with oracle");
        }

        public void Insert(Customer entity)
        {
            Console.WriteLine("inserted with oracle");
        }

        public void Update(Customer entity)
        {
            Console.WriteLine("updated with oracle");
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

}
