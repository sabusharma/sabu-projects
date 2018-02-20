namespace IcecreamShopProject
{
    partial class SalesReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBLTotalSales = new System.Windows.Forms.Label();
            this.DataGridSalesReport = new System.Windows.Forms.DataGridView();
            this.BtnViewReport = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickEndDate = new System.Windows.Forms.DateTimePicker();
            this.PickStartDate = new System.Windows.Forms.DateTimePicker();
            this.RBADay = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBMultipleDays = new System.Windows.Forms.RadioButton();
            this.LBLStartDate = new System.Windows.Forms.Label();
            this.LBLEndDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSalesReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLTotalSales
            // 
            this.LBLTotalSales.AutoSize = true;
            this.LBLTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTotalSales.Location = new System.Drawing.Point(274, 500);
            this.LBLTotalSales.Name = "LBLTotalSales";
            this.LBLTotalSales.Size = new System.Drawing.Size(94, 18);
            this.LBLTotalSales.TabIndex = 0;
            this.LBLTotalSales.Text = "Total Sale: ";
            // 
            // DataGridSalesReport
            // 
            this.DataGridSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.CustomerName,
            this.Total});
            this.DataGridSalesReport.Location = new System.Drawing.Point(277, 73);
            this.DataGridSalesReport.Name = "DataGridSalesReport";
            this.DataGridSalesReport.Size = new System.Drawing.Size(441, 411);
            this.DataGridSalesReport.TabIndex = 1;
            // 
            // BtnViewReport
            // 
            this.BtnViewReport.Location = new System.Drawing.Point(49, 298);
            this.BtnViewReport.Name = "BtnViewReport";
            this.BtnViewReport.Size = new System.Drawing.Size(175, 23);
            this.BtnViewReport.TabIndex = 2;
            this.BtnViewReport.Text = "View Report";
            this.BtnViewReport.UseVisualStyleBackColor = true;
            this.BtnViewReport.Click += new System.EventHandler(this.BtnViewReport_Click);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 180;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 60;
            // 
            // PickEndDate
            // 
            this.PickEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PickEndDate.Location = new System.Drawing.Point(67, 50);
            this.PickEndDate.Name = "PickEndDate";
            this.PickEndDate.Size = new System.Drawing.Size(102, 20);
            this.PickEndDate.TabIndex = 3;
            this.PickEndDate.ValueChanged += new System.EventHandler(this.PickEndDate_ValueChanged);
            // 
            // PickStartDate
            // 
            this.PickStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PickStartDate.Location = new System.Drawing.Point(67, 19);
            this.PickStartDate.Name = "PickStartDate";
            this.PickStartDate.Size = new System.Drawing.Size(102, 20);
            this.PickStartDate.TabIndex = 4;
            this.PickStartDate.ValueChanged += new System.EventHandler(this.PickStartDate_ValueChanged);
            // 
            // RBADay
            // 
            this.RBADay.AutoSize = true;
            this.RBADay.Location = new System.Drawing.Point(38, 23);
            this.RBADay.Name = "RBADay";
            this.RBADay.Size = new System.Drawing.Size(54, 17);
            this.RBADay.TabIndex = 5;
            this.RBADay.TabStop = true;
            this.RBADay.Text = "A Day";
            this.RBADay.UseVisualStyleBackColor = true;
            this.RBADay.CheckedChanged += new System.EventHandler(this.RBADay_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBMultipleDays);
            this.groupBox1.Controls.Add(this.RBADay);
            this.groupBox1.Location = new System.Drawing.Point(22, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Report For";
            // 
            // RBMultipleDays
            // 
            this.RBMultipleDays.AutoSize = true;
            this.RBMultipleDays.Location = new System.Drawing.Point(38, 46);
            this.RBMultipleDays.Name = "RBMultipleDays";
            this.RBMultipleDays.Size = new System.Drawing.Size(88, 17);
            this.RBMultipleDays.TabIndex = 6;
            this.RBMultipleDays.TabStop = true;
            this.RBMultipleDays.Text = "Multiple Days";
            this.RBMultipleDays.UseVisualStyleBackColor = true;
            this.RBMultipleDays.CheckedChanged += new System.EventHandler(this.RBMultipleDays_CheckedChanged);
            // 
            // LBLStartDate
            // 
            this.LBLStartDate.AutoSize = true;
            this.LBLStartDate.Location = new System.Drawing.Point(7, 22);
            this.LBLStartDate.Name = "LBLStartDate";
            this.LBLStartDate.Size = new System.Drawing.Size(58, 13);
            this.LBLStartDate.TabIndex = 7;
            this.LBLStartDate.Text = "Start Date:";
            // 
            // LBLEndDate
            // 
            this.LBLEndDate.AutoSize = true;
            this.LBLEndDate.Location = new System.Drawing.Point(7, 54);
            this.LBLEndDate.Name = "LBLEndDate";
            this.LBLEndDate.Size = new System.Drawing.Size(55, 13);
            this.LBLEndDate.TabIndex = 8;
            this.LBLEndDate.Text = "End Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PickStartDate);
            this.groupBox2.Controls.Add(this.LBLEndDate);
            this.groupBox2.Controls.Add(this.PickEndDate);
            this.groupBox2.Controls.Add(this.LBLStartDate);
            this.groupBox2.Location = new System.Drawing.Point(22, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 87);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "SALES REPORT";
            // 
            // LBLDate
            // 
            this.LBLDate.AutoSize = true;
            this.LBLDate.Location = new System.Drawing.Point(443, 37);
            this.LBLDate.Name = "LBLDate";
            this.LBLDate.Size = new System.Drawing.Size(0, 13);
            this.LBLDate.TabIndex = 11;
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 531);
            this.Controls.Add(this.LBLDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnViewReport);
            this.Controls.Add(this.DataGridSalesReport);
            this.Controls.Add(this.LBLTotalSales);
            this.Name = "SalesReportForm";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSalesReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLTotalSales;
        private System.Windows.Forms.DataGridView DataGridSalesReport;
        private System.Windows.Forms.Button BtnViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DateTimePicker PickEndDate;
        private System.Windows.Forms.DateTimePicker PickStartDate;
        private System.Windows.Forms.RadioButton RBADay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBMultipleDays;
        private System.Windows.Forms.Label LBLStartDate;
        private System.Windows.Forms.Label LBLEndDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLDate;
    }
}