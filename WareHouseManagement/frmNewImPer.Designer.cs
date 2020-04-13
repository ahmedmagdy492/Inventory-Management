namespace WareHouseManagement
{
    partial class frmNewImPer
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.dtExpiration = new System.Windows.Forms.DateTimePicker();
            this.dtProduction = new System.Windows.Forms.DateTimePicker();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMeasureUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtProds = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewPer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbWareHouse = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProds)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nmQuantity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbProvider);
            this.groupBox1.Controls.Add(this.dtExpiration);
            this.groupBox1.Controls.Add(this.dtProduction);
            this.groupBox1.Controls.Add(this.btnNewProduct);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMeasureUnit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة صنف جديد";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "الكمية";
            // 
            // nmQuantity
            // 
            this.nmQuantity.Location = new System.Drawing.Point(172, 102);
            this.nmQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(201, 27);
            this.nmQuantity.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "اسم المورد";
            // 
            // cmbProvider
            // 
            this.cmbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(172, 37);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(201, 29);
            this.cmbProvider.TabIndex = 13;
            // 
            // dtExpiration
            // 
            this.dtExpiration.Location = new System.Drawing.Point(467, 101);
            this.dtExpiration.Name = "dtExpiration";
            this.dtExpiration.Size = new System.Drawing.Size(200, 27);
            this.dtExpiration.TabIndex = 12;
            // 
            // dtProduction
            // 
            this.dtProduction.Location = new System.Drawing.Point(467, 40);
            this.dtProduction.Name = "dtProduction";
            this.dtProduction.Size = new System.Drawing.Size(200, 27);
            this.dtProduction.TabIndex = 11;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(21, 84);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(133, 44);
            this.btnNewProduct.TabIndex = 10;
            this.btnNewProduct.Text = "اضافة منتج جديد";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "تاريخ الانتهاء";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاريخ الانتاج";
            // 
            // txtMeasureUnit
            // 
            this.txtMeasureUnit.Location = new System.Drawing.Point(799, 101);
            this.txtMeasureUnit.Name = "txtMeasureUnit";
            this.txtMeasureUnit.Size = new System.Drawing.Size(201, 27);
            this.txtMeasureUnit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1017, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "وحدة القياس";
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Location = new System.Drawing.Point(799, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 27);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1017, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المنتج";
            // 
            // dtProds
            // 
            this.dtProds.AllowUserToAddRows = false;
            this.dtProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.MeasureUnit,
            this.ProductionDate,
            this.ExpiryDate,
            this.provName,
            this.Quantity});
            this.dtProds.ContextMenuStrip = this.contextMenuStrip1;
            this.dtProds.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtProds.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtProds.Location = new System.Drawing.Point(0, 161);
            this.dtProds.Name = "dtProds";
            this.dtProds.ReadOnly = true;
            this.dtProds.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtProds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtProds.Size = new System.Drawing.Size(1114, 216);
            this.dtProds.TabIndex = 2;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "اسم المنتج";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // MeasureUnit
            // 
            this.MeasureUnit.HeaderText = "وحدة القياس";
            this.MeasureUnit.Name = "MeasureUnit";
            this.MeasureUnit.ReadOnly = true;
            // 
            // ProductionDate
            // 
            this.ProductionDate.HeaderText = "تاريخ الانتاج";
            this.ProductionDate.Name = "ProductionDate";
            this.ProductionDate.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.HeaderText = "تاريخ الصلاحيه";
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // provName
            // 
            this.provName.HeaderText = "اسم المورد";
            this.provName.Name = "provName";
            this.provName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedMenuItem,
            this.editSelectedMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteSelectedMenuItem
            // 
            this.deleteSelectedMenuItem.Name = "deleteSelectedMenuItem";
            this.deleteSelectedMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteSelectedMenuItem.Text = "Delete Selected";
            // 
            // editSelectedMenuItem
            // 
            this.editSelectedMenuItem.Name = "editSelectedMenuItem";
            this.editSelectedMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editSelectedMenuItem.Text = "Edit Selected";
            // 
            // btnNewPer
            // 
            this.btnNewPer.Location = new System.Drawing.Point(312, 395);
            this.btnNewPer.Name = "btnNewPer";
            this.btnNewPer.Size = new System.Drawing.Size(133, 34);
            this.btnNewPer.TabIndex = 3;
            this.btnNewPer.Text = "اضافة أذن جديد";
            this.btnNewPer.UseVisualStyleBackColor = true;
            this.btnNewPer.Click += new System.EventHandler(this.btnNewPer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "المخزن";
            // 
            // cmbWareHouse
            // 
            this.cmbWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWareHouse.FormattingEnabled = true;
            this.cmbWareHouse.Location = new System.Drawing.Point(86, 399);
            this.cmbWareHouse.Name = "cmbWareHouse";
            this.cmbWareHouse.Size = new System.Drawing.Size(193, 29);
            this.cmbWareHouse.TabIndex = 10;
            // 
            // frmNewImPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbWareHouse);
            this.Controls.Add(this.btnNewPer);
            this.Controls.Add(this.dtProds);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmNewImPer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اذن توريد جديد";
            this.Load += new System.EventHandler(this.frmNewImPer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProds)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.DateTimePicker dtExpiration;
        private System.Windows.Forms.DateTimePicker dtProduction;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMeasureUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtProds;
        private System.Windows.Forms.Button btnNewPer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbWareHouse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn provName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}