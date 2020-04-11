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
    public partial class frmClients : Form
    {
        private Clients clientDb;
        public frmClients()
        {
            InitializeComponent();
            clientDb = new Clients();
        }

        private async void frmClients_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "تحميل...";
            // loading all the data
            dtClients.DataSource = await clientDb.GetCustomers();
            lblStatus.Text = "تم";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation.IsNotEmpty(txtName.Text, txtMobile.Text, txtTelephone.Text, txtFax.Text, txtEmail.Text, txtWebsite.Text))
            {
                btnSave.Text = "يتم الحفظ الان...";
                btnSave.Enabled = false;
                // creating new client
                Customer customer = new Customer
                {
                    Name = txtName.Text,
                    MobilePhone = txtMobile.Text,
                    Telephone = txtTelephone.Text,
                    Email = txtEmail.Text,
                    Fax = txtFax.Text,
                    Website = txtWebsite.Text
                };
                dtClients.DataSource = await clientDb.CreateCustomer(customer);
                Utility.EmptyFields(txtName, txtMobile, txtTelephone, txtEmail, txtWebsite, txtFax);
                btnSave.Text = "حفظ";
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("لا يمكن ترك المدخلات فارغه","خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dtClients.SelectedRows.Count == 1)
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
            if(MessageBox.Show("هل تريد فعلا المسح؟", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.OK)
            {
                lblStatus.Text = "تجميل...";
                int id = Convert.ToInt32(dtClients.SelectedRows[0].Cells[0].Value.ToString());
                dtClients.DataSource = await clientDb.DeleteCustomer(id);
                lblStatus.Text = "تم";
            }
        }

        private async void editSelectedMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "تحميل...";
            Customer customer = new Customer
            {
                Id = Convert.ToInt32(dtClients.SelectedRows[0].Cells[0].Value.ToString()),
                Name = dtClients.SelectedRows[0].Cells[1].Value.ToString(),
                Telephone = dtClients.SelectedRows[0].Cells[2].Value.ToString(),
                Fax = dtClients.SelectedRows[0].Cells[3].Value.ToString(),
                MobilePhone = dtClients.SelectedRows[0].Cells[4].Value.ToString(),
                Email = dtClients.SelectedRows[0].Cells[5].Value.ToString(),
                Website = dtClients.SelectedRows[0].Cells[6].Value.ToString()
            };
            frmEditCustomer frmEditCustomer = new frmEditCustomer(customer);
            frmEditCustomer.ShowDialog();
            dtClients.DataSource = await clientDb.EditCustomer(frmEditCustomer.Customer, frmEditCustomer.Customer.Id);
            lblStatus.Text = "تم";
        }
    }
}
