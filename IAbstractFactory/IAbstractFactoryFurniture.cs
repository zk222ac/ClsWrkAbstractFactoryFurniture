using ClsWrkAbstractFactoryFurniture.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkAbstractFactoryFurniture.IAbstractFactory
{
   public interface IAbstractFactoryFurniture
    {
        IAbstractChair CreateChair();
        IAbstractSofa CreateSofa();
        IAbstractCoffeeTable CreateCoffeTable();

    }
}
