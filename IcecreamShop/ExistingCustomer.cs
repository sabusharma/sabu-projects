using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IcecreamShopProject
{
    class ExistingCustomer : Customer
    {
        const double DISCOUNT_RATE = 0.05;
        public override double GetDiscount()
        {
            return DISCOUNT_RATE;
        }
    }
}
