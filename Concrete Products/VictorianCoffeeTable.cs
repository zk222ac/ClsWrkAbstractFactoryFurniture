using ClsWrkAbstractFactoryFurniture.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkAbstractFactoryFurniture.Concrete_Products
{
    class VictorianCoffeeTable : IAbstractCoffeeTable
    {
        public int HasLegs()
        {
            return 4;
        }

        public string SitOn()
        {
            return "only two person can sit on this Victorian coffee Table";
        }
    }
}
