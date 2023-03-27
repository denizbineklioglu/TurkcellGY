using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public static class Rents
    {
        public static IRentable Validate(DateTime date, int rezervationDayCount, int? personCount = null, string model = null)
        {
            if (personCount.HasValue)
            {
                return new Meeting() { Date = date,RezervationDayCount = rezervationDayCount,PersonCount = personCount};
            }
            else if (model != null)
            {
                return new Car() { Date = date,RezervationDayCount = rezervationDayCount, Model = model};
            }
            else
            {
                return new Otel() { Date = date, RezervationDayCount = rezervationDayCount };
            }
        }
    }


    public interface IRentable
    {
        void Validation();
    }

    public class Entity
    {
        public DateTime Date { get; set; }
        public int RezervationDayCount { get; set; }
    }


    public class Car : Entity, IRentable
    {
        public string Model { get; set; }
        public void Validation()
        {
            Console.WriteLine("Car rented.");
        }
    }

    public class Otel : Entity, IRentable
    {        
        public void Validation()
        {
            Console.WriteLine("Hotel Rented");
        }
    }

    public class Meeting : Entity, IRentable
    {
        public int? PersonCount { get; set; }
        public void Validation()
        {
            Console.WriteLine("Meeting room rented.");
        }
    }
}
