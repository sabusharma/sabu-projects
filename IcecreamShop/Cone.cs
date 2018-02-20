using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IcecreamShopProject
{
    class Cone
    {
        private static double COST_PER_SCOOP = 0.50;
        private double COST_PER_CONE = 0.75;

        private double totalCost = 0.0;

        public double TotalCost
        {
            get { return totalCost; }

            set { totalCost = value; }
        }

        public double GetCostPerScoop()
        {
            return COST_PER_SCOOP;
        }

        public double GetCostPerCone()
        {
            return COST_PER_CONE;
        }

        public enum CHOICE_TYPE { IceCream, Yogurt };

        private CHOICE_TYPE choice;

        public CHOICE_TYPE Choice
        {
            get { return (choice); }
            
            set { choice = value; }
        }


        public enum FLAVOR_CHOICE { Chocolate, Vanilla, Strawberry };

        private FLAVOR_CHOICE flavorChoice;

        public FLAVOR_CHOICE FlavorChoice
        {
            get { return (flavorChoice); }
            set { flavorChoice = value; }
        }


        private int numberOfScoops;

        public int NumberOfScoops
        {
            get { return numberOfScoops; }
            set { numberOfScoops = value; }
        }

    }
}
