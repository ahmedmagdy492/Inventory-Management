using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseLib;
using WareHouseManagement.Models;

namespace WareHouseManagement
{
    public partial class frmTempReport : Form
    {
        private Warehouses warehouseDB;
        private SupplyPermissionsProductsDB sppDB;
        private SupplyPermissions spDB;
        private DismissalPermissionDB dpDB;
        private DismissalPerProducts dppDB;
        private readonly List<string> TypeOfPers;
        public frmTempReport()
        {
            InitializeComponent();
            warehouseDB = new Warehouses();
            sppDB = new SupplyPermissionsProductsDB();
            spDB = new SupplyPermissions();
            dpDB = new DismissalPermissionDB();
            dppDB = new DismissalPerProducts();
            TypeOfPers = new List<string>();
            TypeOfPers.AddRange(new string[] { "اذن توريد", "اذن صرف" });
        }

        private async void frmTempReport_Load(object sender, EventArgs e)
        {
            // loading all warehouses
            cmbWarehouses.DataSource = await warehouseDB.GetWarehouses();
            cmbWarehouses.ValueMember = "Id";
            cmbWarehouses.DisplayMember = "Name";
            chckDate.Checked = true;
            dtTo.Value = dtFrom.Value;

            // loading types of permissions
            cmbPermType.DataSource = TypeOfPers;
        }        

        private void AddSupplyInfoToView(DataGridView dt, List<SupplyPermissionProducts> list)
        {
            dtPerProduct.Rows.Clear();
            foreach(var prod in list)
            {
                dtPerProduct.Rows.Add(prod.Product.Name, prod.Quantity, prod.Product.ProductionDate, prod.Product.ExpirationDate);
            }
        }

        private void AddDismissalInfoToView(DataGridView dt, List<DismissalPermissionProducts> list)
        {
            dtPerProduct.Rows.Clear();
            foreach (var prod in list)
            {
                dtPerProduct.Rows.Add(prod.Product.Name, prod.Quantity, prod.Product.ProductionDate, prod.Product.ExpirationDate);
            }
        }

        private void chckDate_CheckedChanged(object sender, EventArgs e)
        {
            if(chckDate.Checked)
            {
                dtFrom.Enabled = true;
                dtTo.Enabled = true;                
            }
            else
            {
                dtFrom.Enabled = false;
                dtTo.Enabled = false;                
            }
        }

        private async void btnGo_Click_1(object sender, EventArgs e)
        {
            if (dtTo.Checked && dtFrom.Value != dtTo.Value)
            {
                if(cmbPermType.SelectedValue.ToString().Contains("اذن توريد"))
                {
                    dtPers.DataSource = await spDB.GetWithDate(dtFrom.Value, dtTo.Value);
                }
                else
                {
                    dtPers.DataSource = await dpDB.GetWithDate(dtFrom.Value, dtTo.Value);
                }
            }
            else
            {
                int warehouseId = Convert.ToInt32(cmbWarehouses.SelectedValue.ToString());
                // getting all permissions
                if (cmbPermType.SelectedValue.ToString().Contains("اذن توريد"))
                {
                    dtPers.DataSource = (await spDB.GetWithId(warehouseId)); //.Select(sp => new { sp.Id, sp.PermissionDate });
                }
                else
                {
                    dtPers.DataSource = (await dpDB.GetWithId(warehouseId)); //.Select(dp => new { dp.Id, dp.PermissionDate });
                }
            }
        }

        private async void dtPers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dtPers.SelectedRows.Count == 1)
            {
                int perId = Convert.ToInt32(dtPers.SelectedRows[0].Cells[0].Value.ToString());
                if (cmbPermType.SelectedValue.ToString().Contains("اذن توريد"))
                {
                    AddSupplyInfoToView(dtPerProduct, await sppDB.GetWithId(perId));
                }
                else
                {
                    AddDismissalInfoToView(dtPerProduct, await dppDB.GetWithPerId(perId));
                }
            }
        }
    }
}
