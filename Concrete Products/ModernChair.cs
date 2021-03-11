using ClsWrkAbstractFactoryFurniture.Abstract_Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkAbstractFactoryFurniture.Concrete_Products
{
    // Variant : Victorian , Modern 
    public class ModernChair : IAbstractChair
    {
        public int HasLegs()
        {
            return 4;
        }

        public string SitOn()
        {
            return "Only one person can sit in this Chair in this modern Chair";
        }
    }
}
