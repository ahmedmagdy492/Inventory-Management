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
    public partial class frmExports : Form
    {
        private DismissalPermissionDB dsDb;
        public frmExports()
        {
            InitializeComponent();
            dsDb = new DismissalPermissionDB();
        }

        private async void frmExports_Load(object sender, EventArgs e)
        {
            // loading all permissions
            dtExports.DataSource = await dsDb.GetAll();
        }

        private async void newExportPer_Click(object sender, EventArgs e)
        {
            frmNewExportPer frm = new frmNewExportPer();
            frm.ShowDialog();
            dtExports.DataSource = await dsDb.GetAll();
        }        
    }
}
