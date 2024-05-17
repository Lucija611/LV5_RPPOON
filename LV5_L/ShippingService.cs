using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_L
{
    public class ShippingService
    {
        private decimal pricePerUnit;

        public ShippingService(decimal pricePerUnit) 
        { 
            this.pricePerUnit = pricePerUnit;
        }

        public decimal CalculateShippingPrice(IShipable item)
        {
            return (decimal)item.Weight * pricePerUnit;
        }
    }
}
