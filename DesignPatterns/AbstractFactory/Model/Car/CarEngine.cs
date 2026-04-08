using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Model.Car
{
    public class CarEngine : IAbstractionEngine
    {
        public void Print()
        {
            Console.WriteLine($"Engine of {this.GetType()} is 1.9 TDI");
        }
    }
}
