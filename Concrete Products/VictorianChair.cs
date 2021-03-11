using ClsWrkAbstractFactoryFurniture.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkAbstractFactoryFurniture.Concrete_Products
{
    class VictorianChair : IAbstractChair
    {
        public int HasLegs()
        {
            return 4; ;
        }

        public string SitOn()
        {
            return "only one person can sit on this victorian chair ";
        }
    }
}
