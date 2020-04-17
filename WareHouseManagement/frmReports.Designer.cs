namespace WareHouseManagement
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWareHouseReport = new System.Windows.Forms.Button();
            this.btnReportProd = new System.Windows.Forms.Button();
            this.btnProdsWithPeriods = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btnWareHouseReport);
            this.flowLayoutPanel1.Controls.Add(this.btnReportProd);
            this.flowLayoutPanel1.Controls.Add(this.btnProdsWithPeriods);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(683, 293);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnWareHouseReport
            // 
            this.btnWareHouseReport.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnWareHouseReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWareHouseReport.ForeColor = System.Drawing.Color.White;
            this.btnWareHouseReport.Location = new System.Drawing.Point(449, 18);
            this.btnWareHouseReport.Name = "btnWareHouseReport";
            this.btnWareHouseReport.Size = new System.Drawing.Size(201, 126);
            this.btnWareHouseReport.TabIndex = 0;
            this.btnWareHouseReport.Text = "تقرير عن مخزن";
            this.btnWareHouseReport.UseVisualStyleBackColor = false;
            this.btnWareHouseReport.Click += new System.EventHandler(this.btnWareHouseReport_Click);
            // 
            // btnReportProd
            // 
            this.btnReportProd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReportProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportProd.ForeColor = System.Drawing.Color.White;
            this.btnReportProd.Location = new System.Drawing.Point(242, 18);
            this.btnReportProd.Name = "btnReportProd";
            this.btnReportProd.Size = new System.Drawing.Size(201, 126);
            this.btnReportProd.TabIndex = 1;
            this.btnReportProd.Text = "تقرير عن منتج محدد";
            this.btnReportProd.UseVisualStyleBackColor = false;
            this.btnReportProd.Click += new System.EventHandler(this.btnReportProd_Click);
            // 
            // btnProdsWithPeriods
            // 
            this.btnProdsWithPeriods.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnProdsWithPeriods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdsWithPeriods.ForeColor = System.Drawing.Color.White;
            this.btnProdsWithPeriods.Location = new System.Drawing.Point(35, 18);
            this.btnProdsWithPeriods.Name = "btnProdsWithPeriods";
            this.btnProdsWithPeriods.Size = new System.Drawing.Size(201, 126);
            this.btnProdsWithPeriods.TabIndex = 2;
            this.btnProdsWithPeriods.Text = "تقرير عن الاصناف التي مر عليها فترة معينة";
            this.btnProdsWithPeriods.UseVisualStyleBackColor = false;
            this.btnProdsWithPeriods.Click += new System.EventHandler(this.btnProdsWithPeriods_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 293);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التقارير";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnWareHouseReport;
        private System.Windows.Forms.Button btnReportProd;
        private System.Windows.Forms.Button btnProdsWithPeriods;
    }
}