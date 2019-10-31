using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public interface Ireporsity<T>where T:class
    {
        IEnumerable<T> GetNew();

        IEnumerable<T> OrderAlphabet();
        IEnumerable<T> OrderPrice();
        double BestValue();
        double FuelCost(int i, double miles);
        T RandomCar();
        double ReturnAve(int i);
        T GetbyID(int i);
    }
}
