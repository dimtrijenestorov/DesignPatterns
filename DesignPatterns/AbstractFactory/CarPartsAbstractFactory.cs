using DesignPatterns.AbstractFactory.Model.Car;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class CarPartsAbstractFactory : IPartsAbstractFactory
    {
        public IAbstractionEngine CreateEngine()
        {
            return new CarEngine();
        }

        public IAbstractionFuel CreateFuel()
        {
            return new CarFuel();
        }

        public IAbstractionSteering CreateSteering()
        {
            return new CarSteering();
        }
    }
}
