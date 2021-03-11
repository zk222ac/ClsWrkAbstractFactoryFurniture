using ClsWrkAbstractFactoryFurniture.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkAbstractFactoryFurniture.Concrete_Products
{
    public class ModernSofa : IAbstractSofa
    {
        public int HasLegs()
        {
            return 4;
        }

        public string SitOn()
        {
            return "the modern sofa is for family memebers";
        }
    }
}
