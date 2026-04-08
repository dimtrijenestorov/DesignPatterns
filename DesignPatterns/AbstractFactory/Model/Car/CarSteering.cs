using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Model.Car
{
    public class CarSteering : IAbstractionSteering
    {
        public void Print()
        {
            Console.WriteLine("Wheely wooo!");
        }
    }
}
