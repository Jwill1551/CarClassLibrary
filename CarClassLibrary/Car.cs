using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car(string Maker, string Model, double Price)
        {
            this.Maker = Maker;
            this.Model = Model;
            this.Price = Price;
        }

        public Car()
        {
            Maker = "Nothing yet";
            Model = "Nothing yet";
            Price = 0;
        }
    }
}
