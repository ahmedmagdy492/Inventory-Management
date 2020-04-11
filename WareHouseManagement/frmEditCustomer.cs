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
    public partial class frmEditCustomer : Form
    {
        public Customer Customer { get; set; }
        public frmEditCustomer(Customer _customer)
        {
            InitializeComponent();
            this.Customer = _customer;
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            txtName.Text = Customer.Name;
            txtMobile.Text = Customer.MobilePhone;
            txtTelephone.Text = Customer.Telephone;
            txtWebsite.Text = Customer.Website;
            txtEmail.Text = Customer.Email;
            txtFax.Text = Customer.Fax;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation.IsNotEmpty(txtName.Text, txtMobile.Text, txtTelephone.Text, txtWebsite.Text, txtEmail.Text, txtFax.Text))
            {
                Customer.Name = txtName.Text;
                Customer.Email = txtEmail.Text;
                Customer.MobilePhone = txtMobile.Text;
                Customer.Fax = txtFax.Text;
                Customer.Website = txtWebsite.Text;
                Customer.Telephone = txtTelephone.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("لا يمكن ترك المدخلات فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }
        
    }
}
