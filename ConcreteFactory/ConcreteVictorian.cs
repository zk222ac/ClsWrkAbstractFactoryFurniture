using ClsWrkAbstractFactoryFurniture.Abstract_Products;
using ClsWrkAbstractFactoryFurniture.Concrete_Products;
using ClsWrkAbstractFactoryFurniture.IAbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkAbstractFactoryFurniture.ConcreteFactory
{
    class ConcreteVictorian : IAbstractFactoryFurniture
    {
        public IAbstractChair CreateChair()
        {
            return new VictorianChair();
        }

        public IAbstractCoffeeTable CreateCoffeTable()
        {
           return new VictorianCoffeeTable();
        }

        public IAbstractSofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
