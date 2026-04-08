using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class PlanePartsAbstractFactory : IPartsAbstractFactory
    {
        public IAbstractionEngine CreateEngine()
        {
            throw new NotImplementedException();
        }

        public IAbstractionFuel CreateFuel()
        {
            throw new NotImplementedException();
        }

        public IAbstractionSteering CreateSteering()
        {
            throw new NotImplementedException();
        }
    }
}
