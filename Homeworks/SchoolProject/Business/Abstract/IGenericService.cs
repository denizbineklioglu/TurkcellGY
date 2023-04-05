using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T entity);
        void Delete(int id);
        void GetAll();
        void Update(T entity);
        int Count();

        T GetById(int id);
    }
}
