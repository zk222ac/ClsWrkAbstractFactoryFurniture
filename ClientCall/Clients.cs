using ClsWrkAbstractFactoryFurniture.ConcreteFactory;
using ClsWrkAbstractFactoryFurniture.IAbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkAbstractFactoryFurniture.ClientCall
{
    class Clients
    {
        public static void Invoke()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first variant (Modern type)...");
            ClientMethod(new ConcreteModern());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the Victorian type...");
            ClientMethod(new ConcreteVictorian());

            Console.WriteLine("Client: Testing the same client code with the Art Deco type...");
            ClientMethod(new ConcreteArtDeco());

        }

        public static void ClientMethod(IAbstractFactoryFurniture factory)
        {
            var chair = factory.CreateChair();
            var sofa = factory.CreateSofa();

            Console.WriteLine(chair.HasLegs());
            Console.WriteLine(chair.SitOn());

            Console.WriteLine(sofa.HasLegs());
            Console.WriteLine(sofa.SitOn());


        }

    }
}
