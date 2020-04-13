namespace WareHouseManagement
{
    partial class ProductsInSuppPer
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
            this.dtProducts = new System.Windows.Forms.DataGridView();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehousename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dtProducts
            // 
            this.dtProducts.AllowUserToAddRows = false;
            this.dtProducts.AllowUserToDeleteRows = false;
            this.dtProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdName,
            this.warehousename,
            this.quantity});
            this.dtProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtProducts.Location = new System.Drawing.Point(0, 0);
            this.dtProducts.Name = "dtProducts";
            this.dtProducts.ReadOnly = true;
            this.dtProducts.Size = new System.Drawing.Size(1162, 452);
            this.dtProducts.TabIndex = 0;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "اسم المنتج";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
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
            // ProductsInSuppPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 452);
            this.Controls.Add(this.dtProducts);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductsInSuppPer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منتجات ";
            this.Load += new System.EventHandler(this.ProductsInSuppPer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehousename;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}