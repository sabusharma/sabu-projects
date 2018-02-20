using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IcecreamShopProject
{
    class WaffleCone : Cone
    {
        private static double COST_PER_WAFFLE_CONE = 1.00;

        new public double GetCostPerCone()
        {
            return COST_PER_WAFFLE_CONE;
        }
    }
}
