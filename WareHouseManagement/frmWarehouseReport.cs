using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseManagement.Models;


namespace WareHouseManagement
{
    public partial class frmWarehouseReport : Form
    {
        private Warehouses warehouseDB;
        private SupplyPermissions spDB;
        private DismissalPerProducts dpDB;
        public frmWarehouseReport()
        {
            InitializeComponent();
            warehouseDB = new Warehouses();
            spDB = new SupplyPermissions();
            dpDB = new DismissalPerProducts();
        }

        private async void LoadReport(string warehouseid)
        {
            ReportParameter[] rps = new ReportParameter[] {
                new ReportParameter("warehouseId", warehouseid),
                new ReportParameter("dateFrom", dtFrom.Value.ToString()),
                new ReportParameter("dtTo", dtTo.Value.ToString())
            };
            ReportDataSource rds = new ReportDataSource("SupplyPermission", await spDB.GetWithId(Convert.ToInt32(warehouseid)));            
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);            
            reportViewer1.LocalReport.SetParameters(rps);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private async void frmWarehouseReport_Load(object sender, EventArgs e)
        {
            // loading all the warehouses
            cmbWarehouses.DataSource = await warehouseDB.GetWarehouses();
            cmbWarehouses.DisplayMember = "Name";
            cmbWarehouses.ValueMember = "Id";
            LoadReport(cmbWarehouses.SelectedValue.ToString());
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if(dtFrom.Value < dtTo.Value)
            {
                LoadReport(cmbWarehouses.SelectedValue.ToString());
            }
        }
    }
}
