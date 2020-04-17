namespace WareHouseManagement
{
    partial class frmImports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImports));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewImPer = new System.Windows.Forms.Button();
            this.dtPers = new System.Windows.Forms.DataGridView();
            this.ttHelpImports = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPers)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNewImPer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1228, 77);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNewImPer
            // 
            this.btnNewImPer.Location = new System.Drawing.Point(987, 13);
            this.btnNewImPer.Name = "btnNewImPer";
            this.btnNewImPer.Size = new System.Drawing.Size(216, 43);
            this.btnNewImPer.TabIndex = 0;
            this.btnNewImPer.Text = "اذن توريد جديد";
            this.btnNewImPer.UseVisualStyleBackColor = true;
            this.btnNewImPer.Click += new System.EventHandler(this.btnNewImPer_Click);
            // 
            // dtPers
            // 
            this.dtPers.AllowUserToAddRows = false;
            this.dtPers.AllowUserToDeleteRows = false;
            this.dtPers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPers.Location = new System.Drawing.Point(0, 77);
            this.dtPers.Name = "dtPers";
            this.dtPers.ReadOnly = true;
            this.dtPers.Size = new System.Drawing.Size(1228, 381);
            this.dtPers.TabIndex = 1;
            this.dtPers.DoubleClick += new System.EventHandler(this.dtPers_DoubleClick);
            // 
            // ttHelpImports
            // 
            this.ttHelpImports.AutoPopDelay = 5000;
            this.ttHelpImports.InitialDelay = 100;
            this.ttHelpImports.IsBalloon = true;
            this.ttHelpImports.ReshowDelay = 100;
            this.ttHelpImports.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttHelpImports.ToolTipTitle = "Help";
            // 
            // frmImports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 458);
            this.Controls.Add(this.dtPers);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmImports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اذونات التوريد";
            this.Load += new System.EventHandler(this.frmImports_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNewImPer;
        private System.Windows.Forms.DataGridView dtPers;
        private System.Windows.Forms.ToolTip ttHelpImports;
    }
}