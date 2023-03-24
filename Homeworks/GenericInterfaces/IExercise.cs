﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaces
{
    /*
        Bu örnekte, generic interface'e iki parametre geçildi
        biri T biri ise Z. Farkları, T sadece dönüş tipi olarak 
        Z ise sadece parametre olarak kullanılabilir.
     */
    public interface IExercise<out T, in Z>
    {
        T GetSomething();
        void Delete(Z z);
    }


    /*
        Generic Interface'in paramteresinden anlayacağımız üzere 
        T sadece parametre olarak kullanılabilir. Action methodu
        dönüş tipi void olduğundan dolayı onda hata çıkartmaz ama Func'ta 
        bir dönüş değeri vardır.Bu yüzden Func ile T kullanılamaz.
     */
    public interface IExercies2<in T>
    {
        Action<T> GetAction();
        //Func<T> GetFunc();
    }


    class Car : ICovariant<Car>
    {
        public Car GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class Computer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class ComputerManager : IContravariant<Computer>, ICovariant<Computer>
    {
        public Computer GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Computer t)
        {
            throw new NotImplementedException();
        }
    }
}
