using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace IcecreamShopProject
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmInitialForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuHelp;
		private System.Windows.Forms.MenuItem mnuNewOrder;
		private System.Windows.Forms.MenuItem mnuSummary;
        private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.MenuItem mnuAbout;
		private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private MenuItem menuSalesReport;
        public Button BTNNewOrder;
        public Button BTNViewSalesReport;
        private MaskedTextBox TBCode;
        private Label label1;
        private Button BTNValidate;
        private GroupBox GroupBoxEnterCode;
        private Label LBLInvalidCode;
        private IContainer components;
        

		public frmInitialForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.IsMdiContainer = true;

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInitialForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuNewOrder = new System.Windows.Forms.MenuItem();
            this.mnuSummary = new System.Windows.Forms.MenuItem();
            this.menuSalesReport = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.BTNNewOrder = new System.Windows.Forms.Button();
            this.BTNViewSalesReport = new System.Windows.Forms.Button();
            this.TBCode = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNValidate = new System.Windows.Forms.Button();
            this.GroupBoxEnterCode = new System.Windows.Forms.GroupBox();
            this.LBLInvalidCode = new System.Windows.Forms.Label();
            this.GroupBoxEnterCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNewOrder,
            this.mnuSummary,
            this.menuSalesReport,
            this.mnuExit});
            this.mnuFile.Text = "&File";
            // 
            // mnuNewOrder
            // 
            this.mnuNewOrder.Index = 0;
            this.mnuNewOrder.Text = "&New Order";
            this.mnuNewOrder.Click += new System.EventHandler(this.mnuTransaction_Click);
            // 
            // mnuSummary
            // 
            this.mnuSummary.Index = 1;
            this.mnuSummary.Text = "&Summary";
            this.mnuSummary.Click += new System.EventHandler(this.mnuSummary_Click);
            // 
            // menuSalesReport
            // 
            this.menuSalesReport.Index = 2;
            this.menuSalesReport.Text = "Sales Report";
            this.menuSalesReport.Click += new System.EventHandler(this.menuSalesReport_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 3;
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 1;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAbout});
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 0;
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // BTNNewOrder
            // 
            this.BTNNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNewOrder.Location = new System.Drawing.Point(12, 177);
            this.BTNNewOrder.Name = "BTNNewOrder";
            this.BTNNewOrder.Size = new System.Drawing.Size(158, 39);
            this.BTNNewOrder.TabIndex = 0;
            this.BTNNewOrder.Text = "New Order";
            this.BTNNewOrder.UseVisualStyleBackColor = true;
            this.BTNNewOrder.Click += new System.EventHandler(this.BTNNewOrder_Click);
            // 
            // BTNViewSalesReport
            // 
            this.BTNViewSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNViewSalesReport.Location = new System.Drawing.Point(12, 234);
            this.BTNViewSalesReport.Name = "BTNViewSalesReport";
            this.BTNViewSalesReport.Size = new System.Drawing.Size(158, 42);
            this.BTNViewSalesReport.TabIndex = 1;
            this.BTNViewSalesReport.Text = "View Sales Report";
            this.BTNViewSalesReport.UseVisualStyleBackColor = true;
            this.BTNViewSalesReport.Click += new System.EventHandler(this.BTNViewSalesReport_Click);
            // 
            // TBCode
            // 
            this.TBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCode.Location = new System.Drawing.Point(35, 35);
            this.TBCode.Name = "TBCode";
            this.TBCode.PasswordChar = '*';
            this.TBCode.Size = new System.Drawing.Size(122, 24);
            this.TBCode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Your Employee Code:";
            // 
            // BTNValidate
            // 
            this.BTNValidate.Location = new System.Drawing.Point(69, 68);
            this.BTNValidate.Name = "BTNValidate";
            this.BTNValidate.Size = new System.Drawing.Size(60, 26);
            this.BTNValidate.TabIndex = 5;
            this.BTNValidate.Text = "Validate";
            this.BTNValidate.UseVisualStyleBackColor = true;
            this.BTNValidate.Click += new System.EventHandler(this.BTNValidate_Click);
            // 
            // GroupBoxEnterCode
            // 
            this.GroupBoxEnterCode.Controls.Add(this.LBLInvalidCode);
            this.GroupBoxEnterCode.Controls.Add(this.label1);
            this.GroupBoxEnterCode.Controls.Add(this.TBCode);
            this.GroupBoxEnterCode.Controls.Add(this.BTNValidate);
            this.GroupBoxEnterCode.Location = new System.Drawing.Point(331, 168);
            this.GroupBoxEnterCode.Name = "GroupBoxEnterCode";
            this.GroupBoxEnterCode.Size = new System.Drawing.Size(197, 129);
            this.GroupBoxEnterCode.TabIndex = 6;
            this.GroupBoxEnterCode.TabStop = false;
            // 
            // LBLInvalidCode
            // 
            this.LBLInvalidCode.AutoSize = true;
            this.LBLInvalidCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLInvalidCode.ForeColor = System.Drawing.Color.Red;
            this.LBLInvalidCode.Location = new System.Drawing.Point(35, 105);
            this.LBLInvalidCode.Name = "LBLInvalidCode";
            this.LBLInvalidCode.Size = new System.Drawing.Size(0, 13);
            this.LBLInvalidCode.TabIndex = 6;
            // 
            // frmInitialForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(856, 534);
            this.Controls.Add(this.GroupBoxEnterCode);
            this.Controls.Add(this.BTNNewOrder);
            this.Controls.Add(this.BTNViewSalesReport);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "frmInitialForm";
            this.Text = "Ice Cream Shop - Order Form";
            this.Load += new System.EventHandler(this.frmInitialForm_Load);
            this.GroupBoxEnterCode.ResumeLayout(false);
            this.GroupBoxEnterCode.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmInitialForm());
		}


		/*
		 * This handler close the form
		 */
		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			/*
			 * Close the form
			 */
			this.Close();				
		}

		/* 
		 * This handler clears the radio buttons and the amount and
		 * resets the focus.
		 */
		private void mnuClear_Click(object sender, System.EventArgs e)
		{
			DialogResult drUserResponse = DialogResult.No;

			drUserResponse = MessageBox.Show
				("This will reset the balance. Continue?",
				"Reset Balance?",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (drUserResponse == DialogResult.Yes)
			{
		
			}
			else
			{
			}
		}


		/*
		 * This handler determines the transaction type from the radio
		 * button input and calls the appropriate routines to perform
		 * the transaction.
		 */
		private void mnuTransaction_Click(object sender, System.EventArgs e)
		{
            OrderForm frmOrderFormObject = new OrderForm();

            frmOrderFormObject.MdiParent = this;
            frmOrderFormObject.Show();

            Cone regCone = new Cone();
            WaffleCone wafCone = new WaffleCone();
            SugarCone sugCone = new SugarCone();

            double cost = regCone.GetCostPerCone();
            cost = wafCone.GetCostPerCone();
            cost = sugCone.GetCostPerCone();



		}

		/*
		 * This handler prints out the account summary including number of
		 * deposits, total deposit amount, number of checks, and total check
		 * amount in a dialog box.
		 */ 
		private void mnuSummary_Click(object sender, System.EventArgs e)
		{
			SummaryForm frmSummaryFormObject = new SummaryForm();

			frmSummaryFormObject.Show();
				         
		}

		/*
		 * This handler displays a color dialog for the user to select.  It
		 * takes the user color selection and change the color for the 
		 * balance label.
		 */
		private void mnuColor_Click(object sender, System.EventArgs e)
		{
			//colorDialog1.Color = lblBalance.ForeColor;

			//colorDialog1.ShowDialog();

			//lblBalance.ForeColor = colorDialog1.Color;
		}

		/*
		 * This handler displays a font dialog for the user to select.  It
		 * takes the user font selection and change the font for the
		 * balance label.
		 */
		private void mnuFont_Click(object sender, System.EventArgs e)
		{
			//fontDialog1.Font = lblBalance.Font;

			//fontDialog1.ShowDialog();

			//lblBalance.Font = fontDialog1.Font;
		}

		/*
		 * This handler displays the program name and the programmer's
		 * name on a dialog box.
		 */
		private void mnuAbout_Click(object sender, System.EventArgs e)
		{
			string strSummary;

			strSummary = "Program Name:  Ice Cream Shop Project \n\n" +
				         "Programmers:\n" +                         
                         "     Sabitri Parajuli\n";

			MessageBox.Show( strSummary, "About Application", MessageBoxButtons.OK,
				MessageBoxIcon.Information);

		}

        private void menuSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportForm salesRPT = new SalesReportForm();
            salesRPT.Show();
        }

        private void BTNNewOrder_Click(object sender, EventArgs e)
        {
            mnuTransaction_Click(sender, e);
            BTNNewOrder.Visible = false;
            BTNViewSalesReport.Visible = false;
        }

        private void BTNViewSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportForm salesRPT = new SalesReportForm();
            salesRPT.Show();

        }

        private void frmInitialForm_Load(object sender, EventArgs e)
        {
            BTNViewSalesReport.Visible = false;
            BTNNewOrder.Visible = false;
            mnuFile.Enabled = false;
            
        }

        private void BTNValidate_Click(object sender, EventArgs e)
        {
            string code = "12345";
            if (TBCode.Text == code)
            {
                EnableControls();
            }
            else 
            {
                LBLInvalidCode.Text = "Invalid Code!";
                TBCode.Text = "";
            }


        }

        public void EnableControls()
        {
            BTNViewSalesReport.Visible = true;
            BTNNewOrder.Visible = true;
            mnuFile.Enabled = true;
            GroupBoxEnterCode.Visible = false;
        
        }

       

      

       

	}
}
