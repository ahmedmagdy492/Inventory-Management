namespace WareHouseManagement
{
    partial class frmExports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExports));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newExportPer = new System.Windows.Forms.Button();
            this.dtExports = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtExports)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.newExportPer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1047, 81);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // newExportPer
            // 
            this.newExportPer.Location = new System.Drawing.Point(878, 18);
            this.newExportPer.Name = "newExportPer";
            this.newExportPer.Size = new System.Drawing.Size(136, 38);
            this.newExportPer.TabIndex = 0;
            this.newExportPer.Text = "اذن صرف جديد";
            this.newExportPer.UseVisualStyleBackColor = true;
            this.newExportPer.Click += new System.EventHandler(this.newExportPer_Click);
            // 
            // dtExports
            // 
            this.dtExports.AllowUserToAddRows = false;
            this.dtExports.AllowUserToDeleteRows = false;
            this.dtExports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtExports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtExports.Location = new System.Drawing.Point(0, 81);
            this.dtExports.Name = "dtExports";
            this.dtExports.ReadOnly = true;
            this.dtExports.Size = new System.Drawing.Size(1047, 369);
            this.dtExports.TabIndex = 1;
            // 
            // frmExports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.dtExports);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اذونات الصرف";
            this.Load += new System.EventHandler(this.frmExports_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtExports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dtExports;
        private System.Windows.Forms.Button newExportPer;
    }
}