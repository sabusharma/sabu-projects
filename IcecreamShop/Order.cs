using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IcecreamShopProject
{
    class Order
    {
        public const int MAX_ORDER = 10;

        NewCustomer myNewCustomer = new NewCustomer();

        ExistingCustomer myExistingCustomer = new ExistingCustomer();

        Cone[] myConeArr = new Cone[MAX_ORDER];

        public void SetOrder(int nOrderNumber, Cone myCone)
        {
            myConeArr[nOrderNumber] = new Cone();

            myConeArr[nOrderNumber].Choice = myCone.Choice;

            myConeArr[nOrderNumber].FlavorChoice = myCone.FlavorChoice;

            myConeArr[nOrderNumber].NumberOfScoops = myCone.NumberOfScoops;

            myConeArr[nOrderNumber].TotalCost = myCone.TotalCost;
        }

        public void PlaceOrder( string FirstName, string LastName, int numberOfItems, ref bool newCustomer, ref double newTotal  )
        {
            
            const string FILENAME = "Customer.txt";
            const char DELIM = ',';            
            bool bCustomerExist = false;

            // Create new file if it does not exist
            FileStream inFile = new FileStream( FILENAME, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recordIn;
            string[] fields;

            newCustomer = true;
            //Defining nullable types
            int? customerID = 0;
            int? tempCustID = null;

            recordIn = reader.ReadLine();

            while ( recordIn != null)
            {
                fields = recordIn.Split(DELIM);

                if ( String.Equals(FirstName.ToUpper(), fields[1]) && String.Equals(LastName.ToUpper(), fields[2]) )
                {
                    bCustomerExist = true;
                    newCustomer = false;
                    customerID = Convert.ToInt32(fields[0]);
                    tempCustID = null;
                    break;
                }
                tempCustID = Convert.ToInt32(fields[0]);
                recordIn = reader.ReadLine();
            }

            reader.Close();
            inFile.Close();

            if (bCustomerExist && !newCustomer)
            {               

                // apply discount for existing customer
                newTotal = newTotal - (newTotal * myExistingCustomer.GetDiscount());
                
            }

            else if(newCustomer)
            {
                FileStream outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outFile);

                // Write to file if new customer
                customerID = Convert.ToInt32(tempCustID) + 1;
                writer.WriteLine(customerID.ToString() + DELIM + FirstName + DELIM + LastName);

                writer.Close();
                outFile.Close();
            }

            double dBalance = Math.Round(newTotal,2);
            
            //Order.txt file is used for keeping track of all the order of Customers with corresponding Order Total.

            FileStream orderFile = new FileStream("Order.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(orderFile);            
            
            sw.WriteLine(DateTime.Now.ToString() + DELIM + customerID.ToString() + DELIM + dBalance);
            sw.Close();
            orderFile.Close();

        }

    }
}
