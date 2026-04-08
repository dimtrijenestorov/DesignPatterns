using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.AbstractFactory;

namespace Playground
{
    class Client
    {
        public static void Main()
        {
            try
            {
                // The client code can work with any concrete factory class.
                Console.WriteLine("Client: Testing client code with the first factory type...");
                ClientMethod(new CarPartsAbstractFactory());
                Console.WriteLine();

                Console.WriteLine("Client: Testing the same client code with the second factory type...");
                ClientMethod(new PlanePartsAbstractFactory());
            }
            catch (NotImplementedException)
            {
                // ignore
            }
        }

        public static void ClientMethod(IPartsAbstractFactory factory)
        {
            var engine = factory.CreateEngine();
            var fuel = factory.CreateFuel();
            var steering = factory.CreateSteering();

            engine.Print();
            fuel.Print();
            steering.Print();
        }
    }
}
