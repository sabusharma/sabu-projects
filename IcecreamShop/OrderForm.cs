using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IcecreamShopProject
{

    public partial class OrderForm : Form
    {
        Order myCurrentOrder = new Order();
        int nOrderCount = 0;
        double dBalance = 0.0;
        double dConeCost = 0.0;

        public OrderForm()
        {
            InitializeComponent();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Cone myCone = new Cone();
            double dOrderCost = 0.0;
            int nOrderNumber = nOrderCount + 1;

            string orderStr = nOrderNumber.ToString() + ". ";

            if ((cbSelItem.SelectedIndex != -1) &&
                 (cbSelFlavor.SelectedIndex != -1) &&
                 (cbSelCone.SelectedIndex != -1) &&
                 (cbScoops.SelectedIndex != -1))
            {
                if (nOrderNumber <= Order.MAX_ORDER)
                {
                    switch (cbSelItem.Items[cbSelItem.SelectedIndex].ToString())
                    {
                        case "Yogurt":
                            myCone.Choice = Cone.CHOICE_TYPE.Yogurt;
                            orderStr += "Yogurt:";
                            break;
                        default:
                            myCone.Choice = Cone.CHOICE_TYPE.IceCream;
                            orderStr += "Ice Cream:";
                            break;
                    }

                    switch (cbSelFlavor.Items[cbSelFlavor.SelectedIndex].ToString())
                    {
                        case "Chocolate":
                            myCone.FlavorChoice = Cone.FLAVOR_CHOICE.Chocolate;
                            orderStr += "Chocolate:";
                            break;
                        case "Vanilla":
                            myCone.FlavorChoice = Cone.FLAVOR_CHOICE.Vanilla;
                            orderStr += "Vanilla:";
                            break;
                        default: // Strawberry
                            myCone.FlavorChoice = Cone.FLAVOR_CHOICE.Strawberry;
                            orderStr += "Strawberry:";
                            break;
                    }

                    switch (cbSelCone.Items[cbSelCone.SelectedIndex].ToString())
                    {
                        case "Regular":
                            dConeCost = myCone.GetCostPerCone();
                            orderStr += "Regular Cone:";
                            break;

                        case "Sugar":
                            SugarCone mySugarCone = new SugarCone();
                            dConeCost = mySugarCone.GetCostPerCone();
                            orderStr += "Sugar Cone:";
                            break;

                        default: // Waffle
                            WaffleCone myWaffleCone = new WaffleCone();
                            dConeCost = myWaffleCone.GetCostPerCone();
                            orderStr += "Waffle Cone:";
                            break;
                    }

                    myCone.NumberOfScoops = Convert.ToInt32(cbScoops.Items[cbScoops.SelectedIndex].ToString());

                    dOrderCost = myCone.NumberOfScoops * myCone.GetCostPerScoop() + (dConeCost);

                    // Set total cost for each cone
                    myCone.TotalCost = dOrderCost;

                    // Add to order
                    if (lbCurrentOrder.Items.Count < Order.MAX_ORDER)
                    {
                        myCurrentOrder.SetOrder(nOrderCount, myCone);
                    }

                    dBalance += dOrderCost;

                    lblBalance.Text = "Balance is " + dBalance.ToString("C");

                    orderStr += myCone.NumberOfScoops.ToString() + " scoop(s):";

                    orderStr += dOrderCost.ToString("C");

                    lbCurrentOrder.Items.Insert(nOrderCount, orderStr);

                    nOrderCount++;
                }
                else
                {
                    MessageBox.Show("Maximum number of 10 orders.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  // end if 
            else
            {
                MessageBox.Show("Please enter all fields in Enter Order form.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        } // end btnOK_Click

        // Clears the current selection.
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbCurrentOrder.Items.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            cbSelItem.Items.Clear();
            cbSelCone.Items.Clear();
            cbSelFlavor.Items.Clear();
            cbScoops.Items.Clear();

            // Put focus on first name text entry
            txtFirstName.Focus();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string orderStr;

            if (lbCurrentOrder.Items.Count > 0)
            {
                try
                {
                    if (IsValidInput())
                    {
                        bool bNewCustomer = true;

                        double dNewBalance = dBalance;

                        Order myOrder = new Order();

                        myOrder.PlaceOrder(txtFirstName.Text.ToUpper(), txtLastName.Text.ToUpper(), nOrderCount, ref bNewCustomer, ref dNewBalance);

                        orderStr = "Customer: " + txtFirstName.Text + " " + txtLastName.Text;
                        orderStr += "\nBalance: " + dNewBalance.ToString("C");

                        if (bNewCustomer)
                        {
                            orderStr += "\n(new customer)";
                        }
                        else
                        {
                            orderStr += "\n(existing customer - 5% discount)";
                        }

                        MessageBox.Show(orderStr, "Order Information");

                        
                        ((frmInitialForm)(this.MdiParent)).BTNNewOrder.Visible = true;
                        ((frmInitialForm)(this.MdiParent)).BTNViewSalesReport.Visible = true;
                        this.Close();

                    }
                }
                catch (InvalidEntryException ex)
                {
                    MessageBox.Show(ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                }
            }
            else
            {
                MessageBox.Show("No order has been placed.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            
            ((frmInitialForm)(this.MdiParent)).BTNNewOrder.Visible = true;
            ((frmInitialForm)(this.MdiParent)).BTNViewSalesReport.Visible = true;
            this.Close();
        }

        private bool IsValidInput()
        {
            if (IsValidText(txtFirstName.Text) && IsValidText(txtLastName.Text))
            {
                return true;
            }
            else
            {
                InvalidEntryException iee = new InvalidEntryException();
                throw (iee);
            }
        }

        private bool IsValidText(string txt)
        {
            Regex objAlphaPattern = new Regex("[^a-zA-Z]");
            return !objAlphaPattern.IsMatch(txt);            
        }

     
    }

    public class InvalidEntryException : Exception
    {
        private static string msg = "Please enter valid customer name.";
        public InvalidEntryException()
            : base(msg)
        {
        }
    }

}
