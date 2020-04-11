namespace WareHouseManagement
{
    partial class MainPanel
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
            this.mainContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnWarehouses = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.mainContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainContainer.Controls.Add(this.btnUsers);
            this.mainContainer.Controls.Add(this.btnClients);
            this.mainContainer.Controls.Add(this.btnSuppliers);
            this.mainContainer.Controls.Add(this.btnWarehouses);
            this.mainContainer.Controls.Add(this.button1);
            this.mainContainer.Controls.Add(this.button2);
            this.mainContainer.Controls.Add(this.btnReports);
            this.mainContainer.Controls.Add(this.btnFullscreen);
            this.mainContainer.Controls.Add(this.btnAbout);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.mainContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainContainer.Size = new System.Drawing.Size(958, 445);
            this.mainContainer.TabIndex = 0;
            // 
            // btnUsers
            // 
            this.btnUsers.Image = global::WareHouseManagement.Properties.Resources.users1;
            this.btnUsers.Location = new System.Drawing.Point(801, 23);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(140, 145);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "ادارة المستخدمين";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnClients
            // 
            this.btnClients.Image = global::WareHouseManagement.Properties.Resources.clients1;
            this.btnClients.Location = new System.Drawing.Point(643, 23);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(152, 145);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "العملاء";
            this.btnClients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Image = global::WareHouseManagement.Properties.Resources.supply;
            this.btnSuppliers.Location = new System.Drawing.Point(465, 23);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(172, 145);
            this.btnSuppliers.TabIndex = 2;
            this.btnSuppliers.Text = "الموردين";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnWarehouses
            // 
            this.btnWarehouses.Image = global::WareHouseManagement.Properties.Resources.warehouse;
            this.btnWarehouses.Location = new System.Drawing.Point(303, 23);
            this.btnWarehouses.Name = "btnWarehouses";
            this.btnWarehouses.Size = new System.Drawing.Size(156, 145);
            this.btnWarehouses.TabIndex = 3;
            this.btnWarehouses.Text = "المخازن";
            this.btnWarehouses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWarehouses.UseVisualStyleBackColor = true;
            this.btnWarehouses.Click += new System.EventHandler(this.btnWarehouses_Click);
            // 
            // button1
            // 
            this.button1.Image = global::WareHouseManagement.Properties.Resources.bill;
            this.button1.Location = new System.Drawing.Point(157, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 145);
            this.button1.TabIndex = 4;
            this.button1.Text = "اذونات التوريد";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::WareHouseManagement.Properties.Resources.dis;
            this.button2.Location = new System.Drawing.Point(17, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 145);
            this.button2.TabIndex = 5;
            this.button2.Text = "اذونات الصرف";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Image = global::WareHouseManagement.Properties.Resources.report;
            this.btnReports.Location = new System.Drawing.Point(801, 174);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(140, 140);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "التقارير";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.Image = global::WareHouseManagement.Properties.Resources.screen;
            this.btnFullscreen.Location = new System.Drawing.Point(643, 174);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(152, 140);
            this.btnFullscreen.TabIndex = 7;
            this.btnFullscreen.Text = "وضع ملأ الشاشة";
            this.btnFullscreen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFullscreen.UseVisualStyleBackColor = true;
            this.btnFullscreen.Click += new System.EventHandler(this.btnFullscreen_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::WareHouseManagement.Properties.Resources.about;
            this.btnAbout.Location = new System.Drawing.Point(465, 174);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(172, 140);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "حول";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 445);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة التحكم";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPanel_FormClosing);
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainContainer;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnWarehouses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnFullscreen;
        private System.Windows.Forms.Button btnAbout;
    }
}