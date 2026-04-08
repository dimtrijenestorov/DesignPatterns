using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.AbstractFactory;
using DesignPatterns.ChainOfResponsibilities;

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

        public static void ClientCode(IHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
}
