using ClsWrkAbstractFactoryFurniture.Abstract_Products;
using ClsWrkAbstractFactoryFurniture.Concrete_Products;
using ClsWrkAbstractFactoryFurniture.IAbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkAbstractFactoryFurniture.ConcreteFactory
{
    public class ConcreteArtDeco : IAbstractFactoryFurniture
    {
        public IAbstractChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public IAbstractCoffeeTable CreateCoffeTable()
        {
            return new ArtDecoCoffeeTable();
        }

        public IAbstractSofa CreateSofa()
        {
            return new ArtDecoSofac();
        }
    }
}
