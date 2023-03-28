using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public interface IPayment
    {
        void GetPayments();
        void GetPaymentStatus();
    }


    public class BankPayment : IPayment
    {
        public void GetPayments()
        {
            throw new NotImplementedException();
        }

        public void GetPaymentStatus()
        {
            throw new NotImplementedException();
        }
    }


    /*
        Bu prensib gereği,implement edilen
        interface'deki tüm özellikler kullanılmak zorunda.
        Kullanılmayan 1 tane bile özellik olmamalı.
     */

    public class ATMPayment //:IPayment
    {
        public void GetPayments()
        {
            throw new NotImplementedException();
        }

        //public void GetPaymentStatus()
        //{
        //    throw new NotImplementedException();
        //}
    }




}
