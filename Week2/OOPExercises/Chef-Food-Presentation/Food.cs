using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises.Chef_Food_Presentation
{
    public class Food
    {
        public string Name { get; set; }
        
        /*
            Method virtual ise, miras alan classlar 
            bu methodu ezebilir.
         */
        public virtual void MakePresentation()
        {
            Console.WriteLine($"{Name} served with rice.");
        }
    }

    public class Baklava : Food
    {
        public override void MakePresentation()
        {
            Console.WriteLine($"{Name} served with ice cream.");
        }
    }

    public class KuruFasulye:Food
    {
        
    }
}
