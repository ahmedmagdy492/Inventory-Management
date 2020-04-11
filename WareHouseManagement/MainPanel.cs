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
    public partial class MainPanel : Form
    {
        private bool isFullScreen;

        public MainPanel()
        {
            InitializeComponent();
        }

        private void MainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            userManager.ShowDialog();
        }

        private void btnWarehouses_Click(object sender, EventArgs e)
        {
            frmWareHouse warehouse = new frmWareHouse();
            warehouse.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            frmProviders frmProviders = new frmProviders();
            frmProviders.ShowDialog();
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            if(!isFullScreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                isFullScreen = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                isFullScreen = false;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            frmClients frmClients = new frmClients();
            frmClients.ShowDialog();
        }
    }
}
