using ClsWrkAbstractFactoryFurniture.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkAbstractFactoryFurniture.Concrete_Products
{
    class VictorianSofa : IAbstractSofa
    {
        public int HasLegs()
        {
            return 4;
        }

        public string SitOn()
        {
            return "This victorian family sofa for a whole family";
        }
    }
}
