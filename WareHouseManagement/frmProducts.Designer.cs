namespace WareHouseManagement
{
    partial class frmProducts
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtProds = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWarehouses = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehousename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProds)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.cmbWarehouses);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1133, 68);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dtProds
            // 
            this.dtProds.AllowUserToAddRows = false;
            this.dtProds.AllowUserToDeleteRows = false;
            this.dtProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodName,
            this.providername,
            this.warehousename,
            this.quantity});
            this.dtProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtProds.Location = new System.Drawing.Point(0, 68);
            this.dtProds.Name = "dtProds";
            this.dtProds.ReadOnly = true;
            this.dtProds.Size = new System.Drawing.Size(1133, 365);
            this.dtProds.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1041, 15);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(59, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "مخزن";
            // 
            // cmbWarehouses
            // 
            this.cmbWarehouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouses.FormattingEnabled = true;
            this.cmbWarehouses.Location = new System.Drawing.Point(783, 18);
            this.cmbWarehouses.Name = "cmbWarehouses";
            this.cmbWarehouses.Size = new System.Drawing.Size(252, 29);
            this.cmbWarehouses.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(641, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // prodName
            // 
            this.prodName.HeaderText = "اسم المنتج";
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            // 
            // providername
            // 
            this.providername.HeaderText = "اسم المورد";
            this.providername.Name = "providername";
            this.providername.ReadOnly = true;
            // 
            // warehousename
            // 
            this.warehousename.HeaderText = "المخزن";
            this.warehousename.Name = "warehousename";
            this.warehousename.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "الكمية";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 433);
            this.Controls.Add(this.dtProds);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProducts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منتجات المخازن";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dtProds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWarehouses;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn providername;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehousename;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}