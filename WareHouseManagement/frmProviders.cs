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
    public partial class frmProviders : Form
    {
        private Providers provDb;
        public frmProviders()
        {
            InitializeComponent();
            provDb = new Providers();
        }

        private async void frmProviders_Load(object sender, EventArgs e)
        {
            // loading all data
            lblStatus.Text = "تحميل...";
            dtProviders.DataSource = await provDb.GetProviders();
            lblStatus.Text = "تم";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation.IsNotEmpty(txtName.Text, txtEmail.Text, txtFax.Text, txtMobile.Text, txtTelephone.Text, txtWebsit.Text))
            {
                btnSave.Text = "يتم الحفظ الان...";
                btnSave.Enabled = false;
                // creating new provider
                Provider provider = new Provider
                {
                    Name = txtName.Text,
                    MobilePhone = txtMobile.Text,
                    Fax = txtFax.Text,
                    Telephone = txtTelephone.Text,
                    Email = txtEmail.Text,
                    Website = txtWebsit.Text
                };
                dtProviders.DataSource = await provDb.CreateProvider(provider);                
                btnSave.Enabled = true;
                btnSave.Text = "حفظ";
                Utility.EmptyFields(txtEmail, txtName, txtFax, txtMobile, txtTelephone, txtWebsit);
            }
            else
            {
                MessageBox.Show("لا يمكن ترك المدخلات فارغه","خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dtProviders.SelectedRows.Count == 1)
            {
                deleteSelectedMenuItem.Enabled = true;
                editSelectedMenuItem.Enabled = true;
            }
            else
            {
                deleteSelectedMenuItem.Enabled = false;
                editSelectedMenuItem.Enabled = false;
            }
        }

        private async void deleteSelectedMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا المسح؟", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.OK)
            {
                lblStatus.Text = "تحميل...";
                // delete the record
                int id = Convert.ToInt32(dtProviders.SelectedRows[0].Cells[0].Value.ToString());
                dtProviders.DataSource = await provDb.DeleteProvider(id);
                lblStatus.Text = "تم";
            }
        }

        private async void editSelectedMenuItem_Click(object sender, EventArgs e)
        {
            Provider prov = new Provider
            {
                Id = Convert.ToInt32(dtProviders.SelectedRows[0].Cells[0].Value.ToString()),
                Name = dtProviders.SelectedRows[0].Cells[1].Value.ToString(),
                Telephone = dtProviders.SelectedRows[0].Cells[2].Value.ToString(),
                Fax = dtProviders.SelectedRows[0].Cells[3].Value.ToString(),
                MobilePhone = dtProviders.SelectedRows[0].Cells[4].Value.ToString(),
                Email = dtProviders.SelectedRows[0].Cells[5].Value.ToString(),
                Website = dtProviders.SelectedRows[0].Cells[6].Value.ToString()
            };
            frmEditProvider editProv = new frmEditProvider(prov);
            editProv.ShowDialog();
            dtProviders.DataSource = await provDb.EditProvider(editProv.Provider, editProv.Provider.Id);
        }
    }
}
