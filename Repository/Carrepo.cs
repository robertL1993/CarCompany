using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Carrepo: ICarRepo
    {
        private List<Car> lst = new List<Car>();
        public void initalCar()
        {      
            lst.Add(new Car() { make = "Honda", color = "Green", Model = "CRV", years = 2016, price = 23845, TCC_Rating = 8, HWY_MPG = 33 });
            lst.Add(new Car() { make = "Ford", color = "Red", Model = "escape", years = 2017, price = 23590, TCC_Rating = 7.8, HWY_MPG = 32 });
            lst.Add(new Car() { make = "Hyundai", color = "Grey", Model = "Sante Fe", years = 2016, price = 24950, TCC_Rating = 8, HWY_MPG = 27 });
            lst.Add(new Car() { make = "Mazda", color = "Red", Model = "CX-5", years = 2017, price = 21795, TCC_Rating = 8, HWY_MPG = 35 });
            lst.Add(new Car() { make = "Subaru", color = "Blue", Model = "Forester", years = 2016, price = 22395, TCC_Rating = 8.4, HWY_MPG = 32 });
        }
        public List<Car> getNewestVehiclesInOrder()
        {
           return lst.OrderByDescending(l => l.years).ToList();
        }
        public List<Car> getalphabetizedr()
        {
            return lst.OrderBy(l=>l.Model).ToList();
        }
        public List<Car> getOrderByPrice()
        {
            return lst.OrderBy(l => l.price).ToList();
        }
        public Car getBestValue()
        {
            return lst.OrderByDescending(l=>l.TCC_Rating).FirstOrDefault();
        }
        public Dictionary<string,double> getFuleConsumption(int distance)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            lst.ForEach(l => dict.Add(l.Model, distance/l.HWY_MPG));
            return dict;
        }
        public Car getRandomCar()
        {
            Random rd = new Random();
            int index =rd.Next(0,5);
            return lst[index];
        }
        public double averageMPGByYear(int year)
        {
            return lst.Where(l => l.years == year).Average(l => l.HWY_MPG);
        }
    }
    public interface ICarRepo
    {
        void initalCar();
        List<Car> getNewestVehiclesInOrder();
        List<Car> getalphabetizedr();
        List<Car> getOrderByPrice();
        Car getBestValue();
        Dictionary<string, double> getFuleConsumption(int distance);
        Car getRandomCar();
        double averageMPGByYear(int year);
    }
}
