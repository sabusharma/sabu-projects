using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IcecreamShopProject
{
    class SugarCone: Cone
    {
        private static double COST_PER_SUGAR_CONE = 0.85;

        new public double GetCostPerCone()
        {
            return COST_PER_SUGAR_CONE;
        }

    }
}
