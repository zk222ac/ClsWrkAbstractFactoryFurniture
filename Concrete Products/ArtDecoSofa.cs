using ClsWrkAbstractFactoryFurniture.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkAbstractFactoryFurniture.Concrete_Products
{
    class ArtDecoSofac : IAbstractSofa
    {
        public int HasLegs()
        {
            return 4; 
        }

        public string SitOn()
        {
            return "Sofa for family sitting , Art Deco Sofa ";
        }
    }
}
