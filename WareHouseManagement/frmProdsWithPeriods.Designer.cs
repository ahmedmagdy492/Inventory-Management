namespace WareHouseManagement
{
    partial class frmProdsWithPeriods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdsWithPeriods));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.nmPeriod = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtProds = new System.Windows.Forms.DataGridView();
            this.colProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.nmTo = new System.Windows.Forms.NumericUpDown();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTo)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.cmbtype);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.nmPeriod);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.nmTo);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1193, 77);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(816, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.label1.Size = new System.Drawing.Size(57, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "من";
            // 
            // nmPeriod
            // 
            this.nmPeriod.Location = new System.Drawing.Point(658, 25);
            this.nmPeriod.Margin = new System.Windows.Forms.Padding(15);
            this.nmPeriod.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmPeriod.Name = "nmPeriod";
            this.nmPeriod.Size = new System.Drawing.Size(140, 27);
            this.nmPeriod.TabIndex = 6;
            this.nmPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(188, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(216, 43);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtProds
            // 
            this.dtProds.AllowUserToAddRows = false;
            this.dtProds.AllowUserToDeleteRows = false;
            this.dtProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdName,
            this.colquantity,
            this.colProdDate,
            this.colExpiry});
            this.dtProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtProds.Location = new System.Drawing.Point(0, 77);
            this.dtProds.Name = "dtProds";
            this.dtProds.ReadOnly = true;
            this.dtProds.Size = new System.Drawing.Size(1193, 397);
            this.dtProds.TabIndex = 2;
            // 
            // colProdName
            // 
            this.colProdName.HeaderText = "اسم المنتج";
            this.colProdName.Name = "colProdName";
            this.colProdName.ReadOnly = true;
            // 
            // colquantity
            // 
            this.colquantity.HeaderText = "الكمية";
            this.colquantity.Name = "colquantity";
            this.colquantity.ReadOnly = true;
            // 
            // colProdDate
            // 
            this.colProdDate.HeaderText = "تاريخ الانتاج";
            this.colProdDate.Name = "colProdDate";
            this.colProdDate.ReadOnly = true;
            // 
            // colExpiry
            // 
            this.colExpiry.HeaderText = "تاريخ الانتهاء";
            this.colExpiry.Name = "colExpiry";
            this.colExpiry.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.label2.Size = new System.Drawing.Size(60, 53);
            this.label2.TabIndex = 7;
            this.label2.Text = "الي";
            // 
            // nmTo
            // 
            this.nmTo.Location = new System.Drawing.Point(422, 25);
            this.nmTo.Margin = new System.Windows.Forms.Padding(15);
            this.nmTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmTo.Name = "nmTo";
            this.nmTo.Size = new System.Drawing.Size(140, 27);
            this.nmTo.TabIndex = 8;
            this.nmTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbtype
            // 
            this.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Location = new System.Drawing.Point(891, 25);
            this.cmbtype.Margin = new System.Windows.Forms.Padding(15);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(137, 29);
            this.cmbtype.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1046, 10);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.label3.Size = new System.Drawing.Size(122, 53);
            this.label3.TabIndex = 10;
            this.label3.Text = "اختار نوع المدة";
            // 
            // frmProdsWithPeriods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 474);
            this.Controls.Add(this.dtProds);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProdsWithPeriods";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أصناف مر عليها فترة زمنية محددة";
            this.Load += new System.EventHandler(this.frmProdsWithPeriods_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown nmPeriod;
        private System.Windows.Forms.DataGridView dtProds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbtype;
    }
}