using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace IcecreamShopProject
{
	/// <summary>
	/// Summary description for SummaryForm.
	/// </summary>
	public class SummaryForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblNumberOfDeposits;
		private System.Windows.Forms.Label lblTotalDepositAmount;
		private System.Windows.Forms.Label lblNumberOfChecks;
		private System.Windows.Forms.Label lblTotalCheckAmount;
		private System.Windows.Forms.Button btnOK;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SummaryForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//lblNumberOfDeposits.Text   = "Number of Deposits: " + Deposit.TotalNumberDeposits.ToString();
 			//lblTotalDepositAmount.Text = "Total Deposit Amount: " + Deposit.TotalDepositAmount.ToString("C");
			//lblNumberOfChecks.Text     = "Number of Checks: " + Check.TotalNumberChecks.ToString();
			//lblTotalCheckAmount.Text   = "Total Check Amount: " + Check.TotalCheckAmount.ToString("C");
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
            this.lblNumberOfDeposits = new System.Windows.Forms.Label();
            this.lblTotalDepositAmount = new System.Windows.Forms.Label();
            this.lblNumberOfChecks = new System.Windows.Forms.Label();
            this.lblTotalCheckAmount = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumberOfDeposits
            // 
            this.lblNumberOfDeposits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDeposits.Location = new System.Drawing.Point(16, 32);
            this.lblNumberOfDeposits.Name = "lblNumberOfDeposits";
            this.lblNumberOfDeposits.Size = new System.Drawing.Size(328, 24);
            this.lblNumberOfDeposits.TabIndex = 0;
            this.lblNumberOfDeposits.Text = "ee";
            // 
            // lblTotalDepositAmount
            // 
            this.lblTotalDepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDepositAmount.Location = new System.Drawing.Point(16, 80);
            this.lblTotalDepositAmount.Name = "lblTotalDepositAmount";
            this.lblTotalDepositAmount.Size = new System.Drawing.Size(328, 24);
            this.lblTotalDepositAmount.TabIndex = 1;
            this.lblTotalDepositAmount.Text = "rr";
            // 
            // lblNumberOfChecks
            // 
            this.lblNumberOfChecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfChecks.Location = new System.Drawing.Point(16, 128);
            this.lblNumberOfChecks.Name = "lblNumberOfChecks";
            this.lblNumberOfChecks.Size = new System.Drawing.Size(328, 24);
            this.lblNumberOfChecks.TabIndex = 2;
            this.lblNumberOfChecks.Text = "ff";
            // 
            // lblTotalCheckAmount
            // 
            this.lblTotalCheckAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCheckAmount.Location = new System.Drawing.Point(16, 176);
            this.lblTotalCheckAmount.Name = "lblTotalCheckAmount";
            this.lblTotalCheckAmount.Size = new System.Drawing.Size(328, 24);
            this.lblTotalCheckAmount.TabIndex = 3;
            this.lblTotalCheckAmount.Text = "gg";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(112, 240);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 32);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // SummaryForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(352, 304);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTotalCheckAmount);
            this.Controls.Add(this.lblNumberOfChecks);
            this.Controls.Add(this.lblTotalDepositAmount);
            this.Controls.Add(this.lblNumberOfDeposits);
            this.Name = "SummaryForm";
            this.Text = "Account Summary";
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}
