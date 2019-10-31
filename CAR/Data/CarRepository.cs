using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Data
{
    public class CarRepository : Ireporsity<data>
    {
        protected CarDBContext _dbContext = new CarDBContext();
        //protected CarRepository(CarDBContext context)
        //{
        //    _dbContext = context;
        //}

        public void Add()
        {
            //Hard code add since the data is not so big//
            //Car1//
            data car1 = new data() { Id = 1, Make = "Honda", Model = "CRV", Color = "Green", Year = 2016, Price = 23845, TCCRating = 8, HwyMPG = 33 };
            _dbContext.Datas.Add(car1);
            //Car2//
            data car2 = new data() { Id = 2, Make = "Ford", Model = "Escape", Color = "Red", Year = 2017, Price = 23590, TCCRating = 7.8, HwyMPG = 32 };
            _dbContext.Datas.Add(car2);
            //Car3//
            data car3 = new data() { Id = 3, Make = "Hyundai", Model = "Sante Fe", Color = "Grey", Year = 2016, Price = 24950, TCCRating = 8, HwyMPG = 27 };
            _dbContext.Datas.Add(car3);
            //Car4//
            data car4 = new data() { Id = 4, Make = "Mazda", Model = "CX-5", Color = "Red", Year = 2017, Price = 21795, TCCRating = 8, HwyMPG = 35 };
            _dbContext.Datas.Add(car4);
            //Car5//
            data car5 = new data() { Id = 5, Make = "Subaru", Model = "Forester", Color = "Blue", Year = 2016, Price = 22395, TCCRating = 8.4, HwyMPG = 32 };
            _dbContext.Datas.Add(car5);
            _dbContext.SaveChanges();
        }





        public double BestValue()
        {
            double ok = _dbContext.Datas.Select(x => x.TCCRating).Max();
            return ok;

        }

        public double FuelCost(int i, double miles)
        {
            double ok = _dbContext.Datas.Where(x => x.Id == 1).Select(x => x.HwyMPG).FirstOrDefault();

            return miles / ok;
        }

        public IEnumerable<data> GetNew()
        {
            //int ok = _dbContext.Datas.Select(x => x.Year).Max();
            //int ok2 = _dbContext.Datas.Where(x => x.Year == ok).Select(x=>x.Id).FirstOrDefault();
            //data fe = GetbyID(ok2);
            IEnumerable<data> lp = _dbContext.Datas.OrderBy(x=>x.Year);
            return lp;
        }

        public IEnumerable<data> OrderAlphabet()
        {
            IEnumerable<data> ok = _dbContext.Datas.OrderBy(x => x.Make);
            return ok;
        }

        public IEnumerable<data> OrderPrice()
        {
            IEnumerable<data> ok = _dbContext.Datas.OrderBy(x => x.Price);
            return ok;
        }

        public data RandomCar()
        {
            int i = _dbContext.Datas.Count();
            Random lk = new Random();
            int ko = lk.Next(1, i + 1);
            return GetbyID(ko);
        }

        public double ReturnAve(int i)
        {
            IEnumerable<data> ok = _dbContext.Datas.Where(x => x.Year == i);
            double lk = ok.Select(x => x.HwyMPG).Average();
            return lk;
        }
      

        public data GetbyID(int i)
        {
            data ok = _dbContext.Datas.Where(x => x.Id == i).FirstOrDefault();
            return ok; throw new NotImplementedException();
        }
    }
}
