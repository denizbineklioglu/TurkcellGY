using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises.AbstractVsInterface.Scenario1
{
    public abstract class Company
    {
        public abstract void Save();
    }

    public class Zara : Company, IWinStar
    {
        public override void Save()
        {
            Console.WriteLine("Saved to database with Mernis verification.");
        }

        public void WinStar()
        {
            throw new NotImplementedException();
        }
    }

    public class Koton : Company
    {
        public override void Save()
        {
            Console.WriteLine("Saved to database.");
        }
    }

    public interface IWinStar
    {
        public void WinStar();
    }
}
