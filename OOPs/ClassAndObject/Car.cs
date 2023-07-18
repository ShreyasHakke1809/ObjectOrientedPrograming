using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.ClassAndObject
{
    internal class Car
    {
        public string model;
        public string colour;
        public double price;

        public void Drive()
        {
            Console.WriteLine("Car can drive");
        }
        public void CarDetails()
        {
            Console.WriteLine("Mode={0} Colour={1} Price={2}", model, colour, price);
        }
    }
}
