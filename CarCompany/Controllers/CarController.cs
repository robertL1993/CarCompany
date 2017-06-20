using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarCompany.Controllers
{
    public class CarController : ApiController
    {
        public readonly IService _Iservice;
        public CarController(IService _Iservice)
        {
            this._Iservice = _Iservice;
            _Iservice.initalCar();
        }
        // GET: api/Car
        [Route("api/Car/GetNewest")]
        public List<Car> GetNewestvehiclesInOder()
        {
            return _Iservice.getNewestVehiclesInOrder();
        }

        // GET: api/Car/5
        [Route("api/Car/getOrderByPrice")]
        public List<Car> getOrderByPrice()
        {
            return _Iservice.getOrderByPrice();
        }

        [Route("api/Car/getalphabetizedr")]
        public List<Car> getalphabetizedr()
        {
            return _Iservice.getalphabetizedr();
        }
        [Route("api/Car/getBestValue")]
        public Car getBestValue()
        {
            return _Iservice.getBestValue();
        }

        [Route("api/Car/getFuleConsumption/{distance:int}")]
        public Dictionary<string, double> getFuleConsumption(int distance)
        {
            return _Iservice.getFuleConsumption(distance);
        }
        [Route("api/Car/getRandomCar")]
        public Car getRandomCar()
        {
            return _Iservice.getRandomCar();
        }
        [Route("api/Car/averageMPGByYear/{year:int}")]
        public IHttpActionResult Get(int year)
        {
            return Ok(_Iservice.averageMPGByYear(year));
        }
    }
}
