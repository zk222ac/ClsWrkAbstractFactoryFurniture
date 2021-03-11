using ClsWrkAbstractFactoryFurniture.Abstract_Products;
using ClsWrkAbstractFactoryFurniture.Concrete_Products;
using ClsWrkAbstractFactoryFurniture.IAbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkAbstractFactoryFurniture.ConcreteFactory
{
    public class ConcreteModern : IAbstractFactoryFurniture
    {
        public IAbstractChair CreateChair()
        {
            return new ModernChair();
        }

        public IAbstractCoffeeTable CreateCoffeTable()
        {
            return new ModernCoffeeTable();
        }

        public IAbstractSofa CreateSofa()
        {
            return new ModernSofa(); ;
        }
    }
}
