using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IcecreamShopProject
{
    abstract class Customer
    {
        private string lastName;
        private string firstName;
        private int customerID;

        public string LastName
        {
            get { return lastName; }

            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }

            set { firstName = value; }
        }

        public int CustomerID
        {
            get { return customerID; }

            set { customerID = value; }
        }

        abstract public double GetDiscount();

    }
}
