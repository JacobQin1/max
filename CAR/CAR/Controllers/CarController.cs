using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data;
using Model;


namespace CAR.Controllers
{
    [RoutePrefix("api/car")]
    public class CarController : ApiController
    {
        CarRepository repo = new CarRepository();

        [Route("Add")]
        public IHttpActionResult GetAddCars()
        {
            repo.Add();
            return Ok();
        }

        [Route("newest")]
        public IEnumerable<data> GetNew()
        {
            
            return repo.GetNew(); 
        }

        [Route("bestvalue")]
        public double GetBestValue()
        {
            
            return repo.BestValue(); 
        }

        [Route("fuelcost")]
        public double GetFuelCost(int i, double miles)
        {

            return repo.FuelCost(i, miles);
        }
        [Route("orderalphabet")]
        public IEnumerable<data> GetOrderAlphabet()
        {

            return repo.OrderAlphabet();
        }

        [Route("orderprice")]
        public IEnumerable<data> GetOrderPrice()
        {

            return repo.OrderPrice();
        }

        [Route("randomcar")]
        public data GetRandomCar()
        {

            return repo.RandomCar();
        }

        [Route("returnave")]
        public double GetReturnAve(int i)
        {

            return repo.ReturnAve(i);
        }
      
    }
}
