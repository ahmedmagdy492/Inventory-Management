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
    public partial class frmImports : Form
    {
        private SupplyPermissions spDb;
        public frmImports()
        {
            InitializeComponent();
            spDb = new SupplyPermissions();
        }

        private async void frmImports_Load(object sender, EventArgs e)
        {
            /// loading all pers data
            dtPers.DataSource =  await spDb.GetAll();

            // show ballon icon
            ttHelpImports.Show("Click Twice on a Selected Record to View Details", this, 5000);
        }

        private async void btnNewImPer_Click(object sender, EventArgs e)
        {
            frmNewImPer frmImper = new frmNewImPer();
            frmImper.ShowDialog();
            dtPers.DataSource =  await spDb.GetAll();
        }

        private async void dtPers_DoubleClick(object sender, EventArgs e)
        {
            if(dtPers.SelectedRows.Count == 1)
            {
                // show the data associated with the selected permission
                int perId = Convert.ToInt32(dtPers.SelectedRows[0].Cells[0].Value.ToString());
                var sp = await spDb.GetAllWithId(perId);

                ProductsInSuppPer frm = new ProductsInSuppPer(sp);
                frm.ShowDialog();
            }
        }
    }
}
