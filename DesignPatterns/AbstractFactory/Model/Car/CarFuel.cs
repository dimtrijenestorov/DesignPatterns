using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Model.Car
{
    public class CarFuel : IAbstractionFuel
    {
        public void Print()
        {
            Console.WriteLine($"Diesel for life baby!!");
        }
    }
}
