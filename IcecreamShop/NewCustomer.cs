using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IcecreamShopProject
{
    class NewCustomer : Customer
    {
        const double DISCOUNT_RATE = 0.0;
        public override double GetDiscount()
        {
            return DISCOUNT_RATE;
        }
    }
}
