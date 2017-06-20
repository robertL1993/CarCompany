using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car
    {
        public string make { get; set; }
        public string Model { get; set; }
        public string color { get; set; }
        public int  years { get; set; }
        public decimal price { get; set; }
        public double TCC_Rating { get; set; }
        public int HWY_MPG { get; set; }
    }
}
