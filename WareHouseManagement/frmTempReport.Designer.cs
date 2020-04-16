namespace WareHouseManagement
{
    partial class frmTempReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTempReport));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWarehouses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPermType = new System.Windows.Forms.ComboBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.dtPers = new System.Windows.Forms.DataGridView();
            this.dtPerProduct = new System.Windows.Forms.DataGridView();
            this.chckDate = new System.Windows.Forms.CheckBox();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPerProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.cmbWarehouses);
            this.flowLayoutPanel1.Controls.Add(this.chckDate);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dtFrom);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.dtTo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1142, 59);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1037, 12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المخزن";
            // 
            // cmbWarehouses
            // 
            this.cmbWarehouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouses.FormattingEnabled = true;
            this.cmbWarehouses.Location = new System.Drawing.Point(816, 15);
            this.cmbWarehouses.Name = "cmbWarehouses";
            this.cmbWarehouses.Size = new System.Drawing.Size(215, 29);
            this.cmbWarehouses.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 12);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(33, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "من";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(469, 15);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 27);
            this.dtFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 12);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(36, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "إلي";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(221, 15);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 27);
            this.dtTo.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.cmbPermType);
            this.flowLayoutPanel2.Controls.Add(this.lblDetails);
            this.flowLayoutPanel2.Controls.Add(this.btnGo);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 59);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(12);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1142, 59);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1045, 12);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(70, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "نوع الاذن";
            // 
            // cmbPermType
            // 
            this.cmbPermType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermType.FormattingEnabled = true;
            this.cmbPermType.Location = new System.Drawing.Point(824, 15);
            this.cmbPermType.Name = "cmbPermType";
            this.cmbPermType.Size = new System.Drawing.Size(215, 29);
            this.cmbPermType.TabIndex = 1;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(785, 12);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Padding = new System.Windows.Forms.Padding(5);
            this.lblDetails.Size = new System.Drawing.Size(33, 31);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "من";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(657, 15);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(122, 29);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click_1);
            // 
            // dtPers
            // 
            this.dtPers.AllowUserToAddRows = false;
            this.dtPers.AllowUserToDeleteRows = false;
            this.dtPers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtPers.Location = new System.Drawing.Point(0, 118);
            this.dtPers.Name = "dtPers";
            this.dtPers.ReadOnly = true;
            this.dtPers.Size = new System.Drawing.Size(599, 321);
            this.dtPers.TabIndex = 3;
            this.dtPers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtPers_MouseDoubleClick);
            // 
            // dtPerProduct
            // 
            this.dtPerProduct.AllowUserToAddRows = false;
            this.dtPerProduct.AllowUserToDeleteRows = false;
            this.dtPerProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPerProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colquantity,
            this.prodDate,
            this.colExpiry});
            this.dtPerProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPerProduct.Location = new System.Drawing.Point(599, 118);
            this.dtPerProduct.Name = "dtPerProduct";
            this.dtPerProduct.ReadOnly = true;
            this.dtPerProduct.Size = new System.Drawing.Size(543, 321);
            this.dtPerProduct.TabIndex = 4;
            // 
            // chckDate
            // 
            this.chckDate.AutoSize = true;
            this.chckDate.Location = new System.Drawing.Point(714, 15);
            this.chckDate.Name = "chckDate";
            this.chckDate.Size = new System.Drawing.Size(96, 25);
            this.chckDate.TabIndex = 6;
            this.chckDate.Text = "بحث بالتاريخ";
            this.chckDate.UseVisualStyleBackColor = true;
            this.chckDate.CheckedChanged += new System.EventHandler(this.chckDate_CheckedChanged);
            // 
            // colName
            // 
            this.colName.HeaderText = "اسم المنتج";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colquantity
            // 
            this.colquantity.HeaderText = "الكمية";
            this.colquantity.Name = "colquantity";
            this.colquantity.ReadOnly = true;
            // 
            // prodDate
            // 
            this.prodDate.HeaderText = "تاريخ الانتاج";
            this.prodDate.Name = "prodDate";
            this.prodDate.ReadOnly = true;
            // 
            // colExpiry
            // 
            this.colExpiry.HeaderText = "تاريخ الانتهاء";
            this.colExpiry.Name = "colExpiry";
            this.colExpiry.ReadOnly = true;
            // 
            // frmTempReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 439);
            this.Controls.Add(this.dtPerProduct);
            this.Controls.Add(this.dtPers);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTempReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير";
            this.Load += new System.EventHandler(this.frmTempReport_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPerProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWarehouses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPermType;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.DataGridView dtPers;
        private System.Windows.Forms.DataGridView dtPerProduct;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.CheckBox chckDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiry;
    }
}