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
    public partial class frmEditWareHouse : Form
    {        
        public Warehouse WareHouse { get; set; }
        public frmEditWareHouse(Warehouse _warehouse)
        {
            InitializeComponent();
            this.WareHouse = _warehouse;            
        }

        private void frmEditWareHouse_Load(object sender, EventArgs e)
        {
            // loading the warehouse data to be modified
            txtName.Text = WareHouse.Name;
            txtAddress.Text = WareHouse.Address;
            txtKeeperName.Text = WareHouse.StoreKeeper;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation.IsNotEmpty(txtName.Text, txtAddress.Text, txtKeeperName.Text))
            {
                WareHouse.Name = txtName.Text;
                WareHouse.Address = txtAddress.Text;
                WareHouse.StoreKeeper = txtKeeperName.Text;
                this.Close();                
            }
            else
            {
                MessageBox.Show("المدخلات غير صحيحة","خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }
    }
}
