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
    public partial class frmWareHouse : Form
    {
        private Warehouses warehouseDb;
        public frmWareHouse()
        {
            InitializeComponent();
            warehouseDb = new Warehouses();
        }

        private async void WareHouse_Load(object sender, EventArgs e)
        {
            // loading all the data
            lblStatus.Text = "تحميل....";
            dtWarehouses.DataSource = await warehouseDb.GetWarehouses();
            lblStatus.Text = "تم";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation.IsNotEmpty(txtName.Text, lblAddress.Text, lblPerson.Text))
            {
                btnSave.Text = "يتم الحفظ الان...";
                btnSave.Enabled = false;
                Warehouse warehouse = new Warehouse
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    StoreKeeper = txtKeeperName.Text
                };
                dtWarehouses.DataSource = await warehouseDb.CreateWareHouse(warehouse);
                btnSave.Text = "حفظ";
                btnSave.Enabled = true;
                Utility.EmptyFields(txtAddress, txtName, txtKeeperName);
            }
            else
            {
                MessageBox.Show("لا يمكن ترك المدخلات فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dtWarehouses.SelectedRows.Count == 1)
            {
                deleteSelectedMenuItem.Enabled = true;
                editSelectedMenuItem.Enabled = true;
            }
            else
            {
                editSelectedMenuItem.Enabled = false;
                deleteSelectedMenuItem.Enabled = false;
            }
        }

        private async void deleteSelectedMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtWarehouses.SelectedRows[0].Cells[0].Value.ToString());
            lblStatus.Text = "تحميل...";
            dtWarehouses.DataSource =  await warehouseDb.DeleteWareHouse(id);
            lblStatus.Text = "تم";
        }

        private async void editSelectedMenuItem_Click(object sender, EventArgs e)
        {
            Warehouse _warehouse = new Warehouse
            {
                Id = Convert.ToInt32(dtWarehouses.SelectedRows[0].Cells[0].Value.ToString()),
                Name = dtWarehouses.SelectedRows[0].Cells[1].Value.ToString(),
                Address = dtWarehouses.SelectedRows[0].Cells[2].Value.ToString(),
                StoreKeeper = dtWarehouses.SelectedRows[0].Cells[3].Value.ToString()
            };
            frmEditWareHouse frmEdit = new frmEditWareHouse(_warehouse);
            frmEdit.ShowDialog();
            lblStatus.Text = "تحميل....";
            dtWarehouses.DataSource =  await warehouseDb.ModifyWarehouse(frmEdit.WareHouse, frmEdit.WareHouse.Id);
            lblStatus.Text = "تم";
        }
    }
}
