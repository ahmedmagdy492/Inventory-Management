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
    public partial class frmEditProvider : Form
    {
        public Provider Provider { get; set; }
        public frmEditProvider(Provider _provider)
        {
            InitializeComponent();
            this.Provider = _provider;
        }

        private void frmEditProvider_Load(object sender, EventArgs e)
        {
            txtName.Text = this.Provider.Name;
            txtMobile.Text = this.Provider.MobilePhone;
            txtPhone.Text = this.Provider.Telephone;
            txtFax.Text = this.Provider.Fax;
            txtEmail.Text = this.Provider.Email;
            txtWebsite.Text = this.Provider.Website;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation.IsNotEmpty(txtName.Text, txtMobile.Text, txtPhone.Text, txtFax.Text, txtEmail.Text, txtWebsite.Text))
            {
                Provider.Name = txtName.Text;
                Provider.MobilePhone = txtMobile.Text;
                Provider.Telephone = txtPhone.Text;
                Provider.Email = txtEmail.Text;
                Provider.Website = txtWebsite.Text;
                Provider.Fax = txtFax.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("لا يمكن ترك مدخلات فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }
        
    }
}
