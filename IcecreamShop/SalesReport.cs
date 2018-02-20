using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IcecreamShopProject
{
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void BtnViewReport_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Order.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            
            string line = sr.ReadLine();
            string[] data;
            double totalSales = 0.0;

            if (DataGridSalesReport.Rows.Count > 0)
            {
                DataGridSalesReport.Rows.Clear();
            }

            while (line != null)
            {
                data = line.Split(',');

                if (RBADay.Checked)
                {
                    DateTime startDate = PickStartDate.Value.Date;
                    if (startDate == Convert.ToDateTime(data[0]).Date)
                    {
                        data[1] = GetCustomerName(data[1]);
                        DataGridSalesReport.Rows.Add(data);                        
                        totalSales += Convert.ToDouble(data[2]);
                        LBLDate.Text = String.Format("({0})", startDate.ToShortDateString());
                    }

                    
                }
                else if (RBMultipleDays.Checked)
                {
                    DateTime startDate = PickStartDate.Value.Date;
                    DateTime endDate = PickEndDate.Value.Date;

                    if (Convert.ToDateTime(data[0]).Date >= startDate && Convert.ToDateTime(data[0]).Date <= endDate)
                    {
                        data[1] = GetCustomerName(data[1]);
                        DataGridSalesReport.Rows.Add(data);
                        totalSales += Convert.ToDouble(data[2]);
                        LBLDate.Text = String.Format("({0} - {1})", startDate.ToShortDateString(), endDate.ToShortDateString());
                    }
                }

                line = sr.ReadLine();            
            }
            LBLTotalSales.Text = "Total Sale: " + totalSales.ToString("C");
            sr.Close();
            fs.Close();
            BtnViewReport.Enabled = false;
        }

        private string GetCustomerName(string custID)
        {
            FileStream fs = new FileStream("Customer.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();
            string custName = null;
            
            while (line != null)
            {
                string[] data = line.Split(',');

                if (String.Equals(custID, data[0]))
                {
                    custName = String.Format("{0} {1}", data[1], data[2]);
                }                
                line = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            return custName;
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            RBADay.Checked = true;
            LBLStartDate.Visible = false;
            LBLEndDate.Visible = false;
            PickEndDate.Visible = false;

        }

        private void RBMultipleDays_CheckedChanged(object sender, EventArgs e)
        {
            LBLStartDate.Visible = true;
            LBLEndDate.Visible = true;
            PickEndDate.Visible = true;
            BtnViewReport.Enabled = true;
        }

        private void RBADay_CheckedChanged(object sender, EventArgs e)
        {
            LBLStartDate.Visible = false;
            LBLEndDate.Visible = false;
            PickEndDate.Visible = false;
            BtnViewReport.Enabled = true;
        }

        private void PickStartDate_ValueChanged(object sender, EventArgs e)
        {
            BtnViewReport.Enabled = true;
        }

        private void PickEndDate_ValueChanged(object sender, EventArgs e)
        {
            BtnViewReport.Enabled = true;
        }
    }
}
