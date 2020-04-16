namespace WareHouseManagement
{
    partial class frmReportPord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportPord));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lsWares = new System.Windows.Forms.ListBox();
            this.chckDate = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnGo = new System.Windows.Forms.Button();
            this.dtProds = new System.Windows.Forms.DataGridView();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProds)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lsWares);
            this.flowLayoutPanel1.Controls.Add(this.chckDate);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.btnGo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1140, 172);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1035, 12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المخزن";
            // 
            // lsWares
            // 
            this.lsWares.FormattingEnabled = true;
            this.lsWares.ItemHeight = 21;
            this.lsWares.Location = new System.Drawing.Point(935, 46);
            this.lsWares.Name = "lsWares";
            this.lsWares.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsWares.Size = new System.Drawing.Size(178, 109);
            this.lsWares.TabIndex = 7;
            // 
            // chckDate
            // 
            this.chckDate.AutoSize = true;
            this.chckDate.Location = new System.Drawing.Point(833, 15);
            this.chckDate.Name = "chckDate";
            this.chckDate.Size = new System.Drawing.Size(96, 25);
            this.chckDate.TabIndex = 6;
            this.chckDate.Text = "بحث بالتاريخ";
            this.chckDate.UseVisualStyleBackColor = true;
            this.chckDate.CheckedChanged += new System.EventHandler(this.chckDate_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.dtFrom);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.dtTo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(618, 15);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(209, 140);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(33, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "من";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(6, 34);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 27);
            this.dtFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 64);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(36, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "إلي";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(6, 98);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 27);
            this.dtTo.TabIndex = 5;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(427, 62);
            this.btnGo.Margin = new System.Windows.Forms.Padding(50);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(138, 46);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // dtProds
            // 
            this.dtProds.AllowUserToAddRows = false;
            this.dtProds.AllowUserToDeleteRows = false;
            this.dtProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodName,
            this.quantity,
            this.dateFrom,
            this.dateTo,
            this.warehouse,
            this.colProvider});
            this.dtProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtProds.Location = new System.Drawing.Point(0, 172);
            this.dtProds.Name = "dtProds";
            this.dtProds.ReadOnly = true;
            this.dtProds.Size = new System.Drawing.Size(1140, 265);
            this.dtProds.TabIndex = 3;
            // 
            // prodName
            // 
            this.prodName.HeaderText = "اسم المنتج";
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "الكمية";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // dateFrom
            // 
            this.dateFrom.HeaderText = "تاريخ الانتاج";
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.ReadOnly = true;
            // 
            // dateTo
            // 
            this.dateTo.HeaderText = "تاريخ الانتهاء";
            this.dateTo.Name = "dateTo";
            this.dateTo.ReadOnly = true;
            // 
            // warehouse
            // 
            this.warehouse.HeaderText = "المخزن";
            this.warehouse.Name = "warehouse";
            this.warehouse.ReadOnly = true;
            // 
            // colProvider
            // 
            this.colProvider.HeaderText = "اسم المورد";
            this.colProvider.Name = "colProvider";
            this.colProvider.ReadOnly = true;
            // 
            // frmReportPord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 437);
            this.Controls.Add(this.dtProds);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReportPord";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير عن منتج";
            this.Load += new System.EventHandler(this.frmReportPord_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chckDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.ListBox lsWares;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.DataGridView dtProds;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvider;
    }
}