using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseManagement
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnWareHouseReport_Click(object sender, EventArgs e)
        {
            frmTempReport frm = new frmTempReport();
            frm.ShowDialog();
        }

        private void btnReportProd_Click(object sender, EventArgs e)
        {
            frmReportPord frm = new frmReportPord();
            frm.ShowDialog();
        }
    }
}
