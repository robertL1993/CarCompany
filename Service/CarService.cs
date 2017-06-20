using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CarService:IService
    {
        public readonly ICarRepo _IcarRepo;
        public CarService(ICarRepo _IcarRepo)
        {
            this._IcarRepo = _IcarRepo;
        }
        public void initalCar()
        {
            _IcarRepo.initalCar();
        }
        public List<Car> getNewestVehiclesInOrder()
        {
            return _IcarRepo.getNewestVehiclesInOrder();
        }
        public List<Car> getalphabetizedr()
        {
            return _IcarRepo.getalphabetizedr();
        }
        public List<Car> getOrderByPrice()
        {
            return _IcarRepo.getOrderByPrice();
        }
        public Car getBestValue()
        {
            return _IcarRepo.getBestValue();
        }
        public Dictionary<string, double> getFuleConsumption(int distance)
        {
            return _IcarRepo.getFuleConsumption(distance);
        }
        public Car getRandomCar()
        {
            return _IcarRepo.getRandomCar();
        }

        public double averageMPGByYear(int year)
        {
            return _IcarRepo.averageMPGByYear(year);
        }
    }
    public interface IService
    {
        void initalCar();
        List<Car> getNewestVehiclesInOrder();
        List<Car> getOrderByPrice();
        List<Car> getalphabetizedr();
        Car getBestValue();
        Dictionary<string, double> getFuleConsumption(int distance);
        Car getRandomCar();
        double averageMPGByYear(int year);
    }
}
